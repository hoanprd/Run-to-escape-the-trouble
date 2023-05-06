using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimationPause : MonoBehaviour
{
    public GameObject StopAni;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.GamePause || GameController.GameOver)
        {
            StopAni.GetComponent<Animator>().enabled = false;
        }
        else
        {
            StopAni.GetComponent<Animator>().enabled = true;
        }
    }
}
