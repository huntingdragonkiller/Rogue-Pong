using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleInstanceTwo : MonoBehaviour
{
    private static SingleInstanceTwo instance = null;
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
