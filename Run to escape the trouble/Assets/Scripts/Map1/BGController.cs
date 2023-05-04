using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    public GameObject BG;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.GameOver == false && GameController.GamePause == false)
        {
            if (BG.transform.position.x < -22.45)
            {
                Destroy(gameObject);
            }

            BG.transform.position = new Vector2(transform.position.x - Time.deltaTime, transform.position.y);
        }
    }
}
