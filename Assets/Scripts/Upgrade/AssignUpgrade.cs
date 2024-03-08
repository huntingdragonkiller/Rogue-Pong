using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AssignUpgrade : MonoBehaviour
{
    public GameObject player;
    public GameObject upgradeSystem;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image artworkImage;

    private UpgradeObjects upgradeObjects;

    // change PlayerStats to Player Paddle?
    // Add SetMaxPerks() in Player Paddle?
    // change Update function to work with UI and mouse
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            upgradeSystem.GetComponent<UpgradeSystem>().AssignUpgradeToObjects();
        }

        if (Input.GetKey(KeyCode.E))
        {
            upgradeSystem.GetComponent<UpgradeSystem>().SetUpgradePhase(true);
        }
        //upgradeTextObject.SetActive(false);
        
    }
    
    public void UpgradeActive()
    {
        player.GetComponent<PlayerPaddle>().AddUpgrade(upgradeObjects, upgradeObjects.ID);

    }

    public void SetUpgrade(UpgradeObjects upgradeToAssign)
    {
        upgradeObjects = upgradeToAssign;

        artworkImage.sprite = upgradeObjects.upgradeSprite;

        nameText.text = upgradeToAssign.name;
        descriptionText.text = upgradeToAssign.description;
        Debug.Log("Upgrades set");
    }
}
