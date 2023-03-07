using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void PlayGame () {
        SceneManager.LoadScene("Rooms and hallway");
    }

    public void QuitGame () {
        Application.Quit();
    }
}
