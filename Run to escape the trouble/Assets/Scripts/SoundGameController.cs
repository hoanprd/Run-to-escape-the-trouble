using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGameController : MonoBehaviour
{
    public AudioSource[] BGMSound, FXSound;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < BGMSound.Length; i++)
        {
            BGMSound[i].volume = PlayerPrefs.GetFloat("SBGM");
        }

        for (int i = 0; i < FXSound.Length; i++)
        {
            FXSound[i].volume = PlayerPrefs.GetFloat("SFX");
        }

        for (int i = 0; i < BGMSound.Length; i++)
        {
            BGMSound[i].Play();
        }
    }
}
