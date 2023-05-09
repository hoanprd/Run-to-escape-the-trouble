using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapItemIns : MonoBehaviour
{
    public GameObject NormalCoinD, NormalCoin2D, SpecialCoinD, SpecialCoin2D, ShieldD, FreezeD, PlusTimerD, NormalCoinM, NormalCoin2M, SpecialCoinM, SpecialCoin2M, ShieldM, FreezeM, PlusTimerM;

    public int ObsDownMidRand, ObsDownRand, ObsMidRand;

    // Start is called before the first frame update
    void Start()
    {
        ObsDownMidRand = Random.Range(1, 3);

        if (ObsDownMidRand == 1)
        {
            ObsDownRand = Random.Range(1, 11);

            if (ObsDownRand <= 3)
            {
                NormalCoinD.SetActive(true);
            }
            else if (ObsDownRand > 3 && ObsDownRand <= 5)
            {
                NormalCoin2D.SetActive(true);
            }
            else if (ObsDownRand == 6)
            {
                SpecialCoinD.SetActive(true);
            }
            else if (ObsDownRand == 7)
            {
                SpecialCoin2D.SetActive(true);
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

            if (ObsMidRand <= 3)
            {
                NormalCoinM.SetActive(true);
            }
            else if (ObsDownRand > 3 && ObsDownRand <= 5)
            {
                NormalCoin2M.SetActive(true);
            }
            else if (ObsMidRand == 6)
            {
                SpecialCoinM.SetActive(true);
            }
            else if (ObsMidRand == 7)
            {
                SpecialCoin2M.SetActive(true);
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
