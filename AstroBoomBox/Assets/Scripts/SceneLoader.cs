using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void SceneStart()
    {
        SceneManager.LoadScene(1);
    }

    public void SceneRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void SceneMain()
    {
        SceneManager.LoadScene(0);
    }

}
