using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject neverDestroy = null;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void OnLevelWasLoaded(int level)
    {
        if(neverDestroy != null)
        {
            return;
        }
        else if (level == 0)
        {
            Destroy(gameObject);
        }
    }
}
