using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCat1 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private LayerMask GroundLayer;

    public float JumpingPower;
    public bool DoubleJump;

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
        if (IsGrounded() && !IsJump)
        {
            DoubleJump = false;
        }

        if (IsJump && !IsSlide)
        {
            IsJump = false;

            /*if (IsGrounded() || !DoubleJump)
            {
                if (IsGrounded())
                {
                    AniCat1.SetTrigger("cat1jump1");
                }
                else
                {
                    AniCat1.SetTrigger("cat1jump2");
                }

                rb.velocity = new Vector2(0, JumpingPower);

                DoubleJump = !DoubleJump;
            }*/

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

        if (IsSlide && IsGrounded())
        {
            AniCat1.applyRootMotion = false;
            if (once == 0)
            {
                once = 1;
                AniCat1.SetBool("cat1slide", true);
            }
        }
        else
        {
            AniCat1.applyRootMotion = true;
            once = 0;
            AniCat1.SetBool("cat1slide", false);
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
}
