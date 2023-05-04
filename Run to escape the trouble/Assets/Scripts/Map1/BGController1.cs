using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController1 : MonoBehaviour
{
    public GameObject BG;
    public int once;

    // Start is called before the first frame update
    void Start()
    {
        once = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (BG.transform.position.x <= -0.02369976 && once == 0)
        {
            once = 1;
            BGIns.Ins = true;
        }
        if (BG.transform.position.x < -22.45)
        {
            Destroy(gameObject);
        }

        BG.transform.position = new Vector2(transform.position.x - Time.deltaTime, transform.position.y);
    }
}
