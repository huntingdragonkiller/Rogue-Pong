using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleInstanceThree : MonoBehaviour
{
    private static SingleInstanceThree instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }
}
