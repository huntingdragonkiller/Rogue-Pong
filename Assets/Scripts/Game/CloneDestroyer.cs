using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneDestroyer : MonoBehaviour
{
    public GameObject levelObj;
    
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("levelObj(Clone)") == null)
        {
            Instantiate(levelObj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
