using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG2Controller : MonoBehaviour
{
    public GameObject BG;

    public int once;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.GameOver == false && GameController.GamePause == false)
        {
            if (BG.transform.position.x < -36.296)
            {
                Destroy(gameObject);
            }

            BG.transform.position = new Vector2(transform.position.x - Time.deltaTime, transform.position.y);
        }

        if (BG.transform.position.x <= -4.796 && once == 0)
        {
            once = 1;
            BGIns.InsBG = true;
            BGIns2.InsBG = true;
        }
    }
}
