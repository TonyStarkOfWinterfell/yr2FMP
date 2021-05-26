using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public double coins;
    public Text coinsText;

    public GameObject popUpHolder2;
    public PopUpSys popUpScript2;
    public bool moneyCheck;

    void Start()
    {
        coins = 0;

        popUpHolder2 = GameObject.FindGameObjectWithTag("Manager");
        popUpScript2 = popUpHolder2.GetComponent<PopUpSys>();

        moneyCheck = false;
    }

   
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.K))
        {
            coins += 100000;
            UpdateCoins();
        }

        if (moneyCheck == false)
        {
            if (coins >= 15)
            {
                popUpScript2.hasMoney = true;
                moneyCheck = true;
            }
        }
    }

    public void UpdateCoins()
    {
        coinsText.text = "£" + coins;        
    }
}
