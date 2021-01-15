using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonCodes : MonoBehaviour
{
    [SerializeField]
    public AudioSource music;

    [SerializeField]
    public GameObject music_open_button, music_close_button;

    public bool music_open;
    public void ExitGame()
    {
        Application.Quit();
    }
    public void MusicClose()
    {
        if (music_open) //Müzik Kapatma
        {
            music.mute = true;
            music_open = false;
            music_open_button.SetActive(true);
            music_close_button.SetActive(false);


        }
    }

    public void MusicOpen() {
        if (!music_open) //Müzik Açma
        {
            music.mute = false;
            music_open = true;
            music_close_button.SetActive(true);
            music_open_button.SetActive(false);

        }
    }
}