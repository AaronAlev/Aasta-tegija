using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuButtons : MonoBehaviour
{
    public void PlayGame () {
        SceneManager.LoadScene("Room2");
    }

    public void QuitGame () {
        Application.Quit();
    }

    public void ToMenu () {
        SceneManager.LoadScene("Main_Menu");
    }

    public AudioMixer audioMixer;

    public void SetVolume (float volume){
        audioMixer.SetFloat("volume", volume);
    }
}
