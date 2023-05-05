using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject[] PopUpBG;
    public GameObject LoadingPanel, ChooseMapPanel, SettingPanel, BGMap1, BGMap2, PlayButtonGo;
    public Text DeText;

    public int BGRand, ChooseMapIndex;
    public float LoadingTime;

    // Start is called before the first frame update
    void Start()
    {
        LoadingTime = 2;

        ChooseMapIndex = 0;

        GameController.GameOver = false;
        GameController.GamePause = false;

        BGRand = Random.Range(0, 2);

        for (int i = 0; i < PopUpBG.Length; i++)
        {
            if (i == BGRand)
            {
                PopUpBG[i].SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LoadingTime > 0)
        {
            LoadingTime -= Time.deltaTime;

            if (LoadingTime <= 0)
            {
                LoadingPanel.SetActive(false);
            }  
        } 
    }

    public void PlayButton()
    {
        ChooseMapPanel.SetActive(true);
    }

    public void ChooseMap1()
    {
        ChooseMapIndex = 1;
        BGMap1.SetActive(true);
        BGMap2.SetActive(false);
        PlayButtonGo.SetActive(true);
        DeText.text = "A forest full of mysteries, waiting for your discovery!";
    }

    public void ChooseMap2()
    {
        ChooseMapIndex = 2;
        BGMap1.SetActive(false);
        BGMap2.SetActive(true);
        PlayButtonGo.SetActive(true);
        DeText.text = "A famous capital city of Vietnam with many interesting things awaits!";
    }

    public void Go()
    {
        if (ChooseMapIndex == 1)
        {
            SceneManager.LoadScene("Map1");
        }
        else if (ChooseMapIndex == 2)
        {
            SceneManager.LoadScene("Map2");
        }
    }    

    public void CloseChooseMapPanel()
    {
        ChooseMapPanel.SetActive(false);
    }

    public void OpenSettingPanel()
    {
        SettingPanel.SetActive(true);
    }

    public void CloseSettingPanel()
    {
        SettingPanel.SetActive(false);
    }    

    public void ExitButton()
    {
        Application.Quit();
    }
}
