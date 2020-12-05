using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadLevel(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void IsExit()
    {
        Application.Quit();
    }

    public void IsReturn()
    {
        SceneManager.LoadScene("Menu");
    }

}
