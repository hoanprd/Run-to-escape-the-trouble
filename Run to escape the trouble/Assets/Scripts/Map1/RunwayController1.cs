using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunwayController1 : MonoBehaviour
{
    public GameObject RunWay;

    public int once;
    public float Speed, DestroyTime;

    // Start is called before the first frame update
    void Start()
    {
        once = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.GameOver == false && GameController.GamePause == false)
        {
            DestroyTime -= Time.deltaTime;

            if (RunWay.transform.position.x <= 0 && once == 0)
            {
                once = 1;
                RunwayIns.InsRunway = true;
            }

            if (DestroyTime <= 0)
            {
                Destroy(gameObject);
            }

            RunWay.transform.position = new Vector2(transform.position.x - Speed, transform.position.y);
        }
    }
}
