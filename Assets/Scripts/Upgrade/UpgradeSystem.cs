using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    public int rangeMin = 0;
    public int rangeMax = 3;

    public GameObject upgrade1;
    public GameObject upgrade2;
    public GameObject upgrade3;

    public List<UpgradeObjects> allUpgradeObjects;
    
    private List<UpgradeObjects> upgradePool = new List<UpgradeObjects>();

    private bool finishedUpgradePhase = false;

    void Start()
    {
        InitializeUpgradePool();
    }

    public void AssignUpgradeToObjects()
    {
        int selectedUpgrade1 = SelectUpgrade();
        int selectedUpgrade2 = SelectUpgrade();
        int selectedUpgrade3 = SelectUpgrade();

        while (selectedUpgrade1 == selectedUpgrade2 ||
            selectedUpgrade1 == selectedUpgrade3 ||
            selectedUpgrade2 == selectedUpgrade3)
        {
            while(selectedUpgrade1 == selectedUpgrade2)
            {
                selectedUpgrade2 = SelectUpgrade();
                Debug.Log("Random Upgrade 1 set");
            }
            while (selectedUpgrade1 == selectedUpgrade3)
            {
                selectedUpgrade3 = SelectUpgrade();
                Debug.Log("Random Upgrade 2 set");
            }
            while (selectedUpgrade2 == selectedUpgrade3)
            {
                selectedUpgrade3 = SelectUpgrade();
                Debug.Log("Random Upgrade 3 set");
            }
        }

        upgrade1.SetActive(true);
        upgrade2.SetActive(true);
        upgrade3.SetActive(true);

        upgrade1.GetComponent<AssignUpgrade>().SetUpgrade(allUpgradeObjects[selectedUpgrade1]);
        upgrade2.GetComponent<AssignUpgrade>().SetUpgrade(allUpgradeObjects[selectedUpgrade2]);
        upgrade3.GetComponent<AssignUpgrade>().SetUpgrade(allUpgradeObjects[selectedUpgrade3]);
    }

    public int SelectUpgrade()
    {
        int upgradeNumber = Random.Range(rangeMin, rangeMax);

        while (upgradePool[upgradeNumber] == null)
        {
            upgradeNumber = Random.Range(rangeMin, rangeMax);
        }
        return upgradeNumber;
    }

    public void SetUpgradePhase(bool newValue)
    {
        finishedUpgradePhase = newValue;
        if(newValue == true)
        {
            upgrade1.SetActive(false);
            upgrade2.SetActive(false);
            upgrade3.SetActive(false);
        }
    }

    public bool GetUpgradePhase()
    {
        return finishedUpgradePhase;
    }

    private void InitializeUpgradePool()
    {
        for(int i = 0; i < allUpgradeObjects.Count; i++)
        {
            upgradePool.Add(allUpgradeObjects[i]);
        }
        Debug.Log("Upgrade pool initialized");
    }

    public void RemoveFromPool(int upgradeToRemove)
    {
        upgradePool[upgradeToRemove] = null;
    }
}
