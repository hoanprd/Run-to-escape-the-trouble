using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserRatController : MonoBehaviour
{
    public GameObject ChaserRat;

    public static int ChaseTrigger;
    public float ChaseCD;
    public static bool IsChasing;

    // Start is called before the first frame update
    void Start()
    {
        ChaseTrigger = 0;
        IsChasing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ChaseTrigger >= 3 && !IsChasing)
        {
            ChaseTrigger = 0;
            IsChasing = true;
            ChaseCD = 5;
            ChaserRat.GetComponent<Animator>().enabled = true;
        }
        else if (IsChasing && ChaseCD > 0)
        {
            ChaseCD -= Time.deltaTime;

            if (ChaseCD <= 0)
            {
                IsChasing = false;
                ChaserRat.GetComponent<Animator>().enabled = false;
            }
        }
    }
}
