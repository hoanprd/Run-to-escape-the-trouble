using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGIns : MonoBehaviour
{
    public GameObject BGI;
    public Transform root;

    public static bool Ins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Ins)
        {
            Ins = false;

            Vector3 spawn_pos = new Vector3(22.2f, 0.6502f, 0);

            Instantiate(BGI, spawn_pos, Quaternion.identity, root);
        }
    }
}