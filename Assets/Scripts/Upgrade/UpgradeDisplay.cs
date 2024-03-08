using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeDisplay : MonoBehaviour
{
    public UpgradeObjects upgradeCard;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image artworkImage;

    void Start()
    {
        nameText.text = upgradeCard.name;
        descriptionText.text = upgradeCard.description;

        artworkImage.sprite = upgradeCard.upgradeSprite;
    }
}
