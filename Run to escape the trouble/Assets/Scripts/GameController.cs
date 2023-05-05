using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject GameOverPanel;
    public Slider TimeSlider;
    public Text ScoreText;

    public static int Score;
    public static float PlayTime;
    public static bool GamePause, GameOver;

    // Start is called before the first frame update
    void Start()
    {
        PlayTime = 90;
        GameOver = false;
        TimeSlider.maxValue = PlayTime;
        TimeSlider.value = TimeSlider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayTime > 0 && GamePause == false)
        {
            PlayTime -= Time.deltaTime;
            TimeSlider.value = PlayTime;
        }
        else if (GamePause == false)
        {
            GameOver = true;
        }

        ScoreText.text = "Score: " + Score;

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
