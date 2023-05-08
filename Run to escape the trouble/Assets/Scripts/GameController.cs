using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Image EffectShieldDisplay, EffectFreezeDisplay, EffectPlusTimeDisplay;
    public GameObject ShieldDisplay, FreezeDisplay;
    public GameObject PausePanel;
    public GameObject GameOverPanel;
    public Slider TimeSlider;
    public Text ScoreText;

    public static int Score;
    public static float PlayTime, FreezeCD;
    public static bool GamePause, GameOver, ShieldActive, FreezeActive, PlusTimeActive;

    // Start is called before the first frame update
    void Start()
    {
        PlayTime = 90;
        GameOver = false;
        TimeSlider.maxValue = PlayTime;
        TimeSlider.value = TimeSlider.maxValue;

        ShieldActive = false;
        FreezeActive = false;
        PlusTimeActive = false;
        FreezeCD = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayTime > 0 && GamePause == false && !FreezeActive)
        {
            PlayTime -= Time.deltaTime;
            TimeSlider.value = PlayTime;
        }
        else if (PlayTime > 0 && FreezeActive)
        {
            TimeSlider.value = PlayTime;
        }
        else if (PlayTime <= 0 && FreezeActive)
        {
            GameOver = true;
            TimeSlider.value = PlayTime;
        }
        else if (GamePause == false && !FreezeActive)
        {
            GameOver = true;
            TimeSlider.value = PlayTime;
        }

        ScoreText.text = "Score: " + Score;

        if (ShieldActive)
        {
            EffectShieldDisplay.color = new Color(EffectShieldDisplay.color.r, EffectShieldDisplay.color.g, EffectShieldDisplay.color.b, 1f);
            ShieldDisplay.SetActive(true);
        }
        else
        {
            EffectShieldDisplay.color = new Color(EffectShieldDisplay.color.r, EffectShieldDisplay.color.g, EffectShieldDisplay.color.b, 0.4f);
            ShieldDisplay.SetActive(false);
        }

        if (FreezeActive)
        {
            EffectFreezeDisplay.color = new Color(EffectFreezeDisplay.color.r, EffectFreezeDisplay.color.g, EffectFreezeDisplay.color.b, 1f);
            FreezeDisplay.SetActive(true);

            if (FreezeCD > 0)
            {
                FreezeCD -= Time.deltaTime;
            }
            else
            {
                FreezeActive = false;
                FreezeCD = 10;
            }
        }
        else
        {
            EffectFreezeDisplay.color = new Color(EffectFreezeDisplay.color.r, EffectFreezeDisplay.color.g, EffectFreezeDisplay.color.b, 0.4f);
            FreezeDisplay.SetActive(false);
        }

        if (PlusTimeActive)
        {
            EffectPlusTimeDisplay.color = new Color(EffectPlusTimeDisplay.color.r, EffectPlusTimeDisplay.color.g, EffectPlusTimeDisplay.color.b, 1f);
            if ((PlayTime + 10) > 90)
            {
                PlayTime = 90;
            }
            else
            {
                PlayTime += 10;
            }

            PlusTimeActive = false;
        }
        else
        {
            EffectPlusTimeDisplay.color = new Color(EffectPlusTimeDisplay.color.r, EffectPlusTimeDisplay.color.g, EffectPlusTimeDisplay.color.b, 0.4f);
        }

        if (GameOver)
        {
            TimeSlider.value = 0;
            PausePanel.SetActive(false);
            GameOverPanel.SetActive(true);
            StartCoroutine(GoToGameMenu());
        }
    }

    public void OpenPausePanel()
    {
        GamePause = true;
        PausePanel.SetActive(true);
    }

    public void ResumePress()
    {
        GamePause = false;
        PausePanel.SetActive(false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    IEnumerator GoToGameMenu()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Menu");
    }
}
