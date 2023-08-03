using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitApps()
    {
        Application.Quit();
    }
}
