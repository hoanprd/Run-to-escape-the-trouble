using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map2ObsIns : MonoBehaviour
{
    public GameObject[] ObsDown, ObsMid, ObsUp;

    public int ObsUpDownMidRand, ObsDownRand, ObsMidRand, ObsUpRand;

    // Start is called before the first frame update
    void Start()
    {
        ObsUpDownMidRand = Random.Range(1, 5);

        if (ObsUpDownMidRand <= 2)
        {
            ObsDownRand = Random.Range(0, 4);

            for (int i = 0; i < ObsDown.Length; i++)
            {
                if (i == ObsDownRand)
                {
                    ObsDown[i].SetActive(true);
                }
            }
        }
        else if (ObsUpDownMidRand == 3)
        {
            ObsMidRand = Random.Range(0, 1);

            for (int i = 0; i < ObsMid.Length; i++)
            {
                if (i == ObsMidRand)
                {
                    ObsMid[i].SetActive(true);
                }
            }
        }
        else
        {
            ObsUpRand = Random.Range(0, 1);

            for (int i = 0; i < ObsUp.Length; i++)
            {
                if (i == ObsUpRand)
                {
                    ObsUp[i].SetActive(true);
                }
            }
        }
    }
}
