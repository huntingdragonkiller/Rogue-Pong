using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int levelGenerate;
    public GameObject destroyPlayerPaddle;
    public GameObject destroyComputerPaddle;
    public GameObject destroyBall;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    /*
    public void ExitLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }
    */

    public void LoadRandomScene()
    {
        levelGenerate = Random.Range(2, 6);
        SceneManager.LoadScene(levelGenerate);
    }
}
