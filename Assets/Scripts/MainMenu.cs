using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    // Start is called before the first frame update
    public void PlayGame ()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}
