using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGIns2 : MonoBehaviour
{
    public GameObject BGI;
    public Transform root;

    public static bool InsBG;

    // Start is called before the first frame update
    void Start()
    {
        InsBG = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (InsBG)
        {
            InsBG = false;

            Vector3 spawn_pos = new Vector3(33.454f, 2.027f, 0);

            Instantiate(BGI, spawn_pos, Quaternion.identity, root);
        }
    }
}
