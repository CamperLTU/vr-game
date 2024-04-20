using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void scenegame()
    {
        SceneManager.LoadScene("BasicScene");
    }
    public void scenemenu()
    {
        SceneManager.LoadScene("main menu");
    }
    public void exit()
    {
        Application.Quit();
    }
}
