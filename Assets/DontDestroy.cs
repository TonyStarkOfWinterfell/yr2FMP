using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{

    public double currentMoney = 0;
    public double highMoney = 0;


    public bool created = false;


    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Cross");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
        
}
