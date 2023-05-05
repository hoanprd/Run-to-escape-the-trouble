using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunwayIns : MonoBehaviour
{
    public GameObject RI;

    public static bool InsRunway;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (InsRunway)
        {
            InsRunway = false;

            Vector3 spawn_pos = new Vector3(33.8f, 0, 0);

            Instantiate(RI, spawn_pos, Quaternion.identity);
        }
    }
}
