using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    private Button resetButton;

    void Update()
    {
        resetButton = GetComponent<Button>();
        resetButton.onClick.AddListener(ResetActivate);
    }

    private void ResetActivate()
    {
        Debug.Log("Reset Highscore!");
        PlayerPrefs.SetInt("HighScore", 0);
    }
}
