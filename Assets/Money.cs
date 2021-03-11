using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public double coins;
    public Text coinsText;

   
    void Start()
    {
        coins = 0;
    }

   
    void Update()
    {
        
    }

    public void UpdateCoins()
    {
        coinsText.text = "£" + coins;        
    }
}
