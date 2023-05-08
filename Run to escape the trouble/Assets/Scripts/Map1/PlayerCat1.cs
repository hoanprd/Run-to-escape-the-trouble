using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCat1 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private LayerMask GroundLayer;

    public float JumpingPower;
    public bool DoubleJump, GetHit;

    public GameObject Cat1;
    public Animator AniCat1;
    public bool IsJump, IsSlide;
    private int once;

    // Start is called before the first frame update
    void Start()
    {
        once = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGrounded() && !IsJump && GameController.GameOver == false && GameController.GamePause == false)
        {
            DoubleJump = false;
        }

        if (IsJump && !IsSlide && GameController.GameOver == false && GameController.GamePause == false)
        {
            IsJump = false;

            if (IsGrounded())
            {
                AniCat1.SetTrigger("cat1jump1");

                rb.velocity = new Vector2(0, JumpingPower);
            }
            else if (!DoubleJump)
            {
                AniCat1.SetTrigger("cat1jump2");

                rb.velocity = new Vector2(0, JumpingPower);

                DoubleJump = true;
            }
        }

        if (IsSlide && IsGrounded() && GameController.GameOver == false && GameController.GamePause == false && !GetHit)
        {
            AniCat1.applyRootMotion = false;
            if (once == 0)
            {
                once = 1;
                AniCat1.SetBool("cat1slide", true);
            }
        }
        else if (GameController.GameOver == false && GameController.GamePause == false)
        {
            AniCat1.applyRootMotion = true;
            once = 0;
            AniCat1.SetBool("cat1slide", false);
        }

        if (GameController.GameOver == true && GameController.GamePause == false)
        {
            AniCat1.applyRootMotion = false;
            AniCat1.SetBool("cat1die", true);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(GroundCheck.position, 0.2f, GroundLayer);
    }

    public void Jump()
    {
        IsJump = true;
    }

    public void Slide(bool _IsSlide)
    {
        IsSlide = _IsSlide;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            GameController.Score += 10;
        }

        if (collision.CompareTag("Obs"))
        {
            if (GameController.ShieldActive)
            {
                GameController.ShieldActive = false;
            }
            else
            {
                GetHit = true;

                if (!ChaserRatController.IsChasing)
                {
                    ChaserRatController.ChaseTrigger += 1;
                }

                GameController.GetHitStatus = true;
                GameController.PlayTime -= 5;
                AniCat1.SetTrigger("cat1fall");
                if (Cat1.transform.position.x <= -5)
                {
                    Cat1.transform.position = new Vector2(-5, transform.position.y);
                }
                StartCoroutine(DelaySlide());
            }  
        }

        if (collision.CompareTag("ObsSlide") && !IsSlide)
        {
            if (GameController.ShieldActive)
            {
                GameController.ShieldActive = false;
            }
            else
            {
                GetHit = true;

                if (!ChaserRatController.IsChasing)
                {
                    ChaserRatController.ChaseTrigger += 1;
                }

                GameController.GetHitStatus = true;
                GameController.PlayTime -= 5;
                AniCat1.SetTrigger("cat1fall");
                if (Cat1.transform.position.x <= -5)
                {
                    Cat1.transform.position = new Vector2(-5, transform.position.y);
                }
                StartCoroutine(DelaySlide());
            }
        }
    }

    IEnumerator DelaySlide()
    {
        yield return new WaitForSeconds(0.5f);
        GetHit = false;
    }
}
