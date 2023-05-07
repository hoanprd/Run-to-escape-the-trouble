using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapItemIns : MonoBehaviour
{
    public GameObject NormalCoinD, SpecialCoinD, ShieldD, FreezeD, PlusTimerD, NormalCoinM, SpecialCoinM, ShieldM, FreezeM, PlusTimerM;

    public int ObsDownMidRand, ObsDownRand, ObsMidRand;

    // Start is called before the first frame update
    void Start()
    {
        ObsDownMidRand = Random.Range(1, 3);

        if (ObsDownMidRand == 1)
        {
            ObsDownRand = Random.Range(1, 11);

            if (ObsDownRand <= 5)
            {
                NormalCoinD.SetActive(true);
            }
            else if (ObsDownRand > 5 && ObsDownRand <= 7)
            {
                SpecialCoinD.SetActive(true);
            }
            else if (ObsDownRand == 8)
            {
                ShieldD.SetActive(true);
            }
            else if (ObsDownRand == 9)
            {
                FreezeD.SetActive(true);
            }
            else
            {
                PlusTimerD.SetActive(true);
            }
        }
        else
        {
            ObsMidRand = Random.Range(1, 11);

            if (ObsMidRand <= 5)
            {
                NormalCoinM.SetActive(true);
            }
            else if (ObsMidRand > 5 && ObsDownRand <= 7)
            {
                SpecialCoinM.SetActive(true);
            }
            else if (ObsMidRand == 8)
            {
                ShieldM.SetActive(true);
            }
            else if (ObsMidRand == 9)
            {
                FreezeM.SetActive(true);
            }
            else
            {
                PlusTimerM.SetActive(true);
            }
        }
    }
}
