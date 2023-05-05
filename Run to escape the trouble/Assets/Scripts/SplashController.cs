using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
    public float SplashTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SplashTime > 0)
        {
            SplashTime -= Time.deltaTime;

            if (SplashTime <= 0)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
