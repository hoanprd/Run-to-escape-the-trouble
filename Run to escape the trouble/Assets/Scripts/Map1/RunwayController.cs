using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunwayController : MonoBehaviour
{
    public GameObject RunWay;
    public float Speed, DestroyTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DestroyTime -= Time.deltaTime;

        if (DestroyTime <= 0)
        {
            Destroy(gameObject);
        }

        RunWay.transform.position = new Vector2(transform.position.x - Speed, transform.position.y);
    }
}
