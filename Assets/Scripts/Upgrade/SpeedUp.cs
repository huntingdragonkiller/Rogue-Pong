using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [SerializeField] private GameObject playerPaddle;
    private float speedIncreaseAmount = 0.5f;

    public void UpgradeActivate()
    {
        Debug.Log("Upgrade activated (speed)");
        playerPaddle.GetComponent<PlayerPaddle>().AddSpeed(speedIncreaseAmount);
    }
}
