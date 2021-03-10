using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public GameObject manageHolder;
    public Money money;
    


    private void Start()
    {
        manageHolder = GameObject.FindGameObjectWithTag("Manager");
        money = manageHolder.GetComponent<Money>();
    }


    public void UP1()
    {
        if (money.coins == 20)
        {


        }
    }
}
