using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject[] PopUpBG;
    public GameObject LoadingPanel, ChooseMapPanel, SettingPanel;

    public int BGRand;
    public float LoadingTime;

    // Start is called before the first frame update
    void Start()
    {
        LoadingTime = 2;

        GameController.GameOver = false;

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
        SceneManager.LoadScene("Map1");
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
