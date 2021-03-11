using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public GameObject manageHolder;
    public Money money;

    public GameObject mainButtonHolder;
    public ButtonScript mainClick;


    private int U1 = 0;
    private int U2 = 0;
    private int U3 = 0;
    private int U4 = 0;
    private int U5 = 0;
    private int U6 = 0;
    private int U7 = 0;
    private int U8 = 0;
    private int U9 = 0;
    private int U10 = 0;
    private int U11 = 0;
  
    
    private void Start()
    {
        manageHolder = GameObject.FindGameObjectWithTag("Manager");
        money = manageHolder.GetComponent<Money>();

        mainButtonHolder = GameObject.FindGameObjectWithTag("SPHolder");
        mainClick = mainButtonHolder.GetComponent<ButtonScript>();
    }

    public void AddMoney()
    {
        money.coins += 20;        
        money.UpdateCoins();
    }

    public void UP1()
    {
        if (U1 == 0)
        {
            if (money.coins >= 15)
            {
                U1 = 1;
                money.coins -= 15;
                money.UpdateCoins();
                
                mainClick.currentClick = 15;                
            }
            else
            {
                //play no money audio
            }
        }

    }
    public void UP2()
    {
        if (U2 == 0)
        {
            if (money.coins >= 75)
            {
                U2 = 1;
                money.coins -= 75;
                money.UpdateCoins();

                mainClick.currentFPS = 15;
                mainClick.ifAuto = true;                
            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP3()
    {
        if (U3 == 0)
        {
            if (money.coins >= 250)
            {
                U3= 1;
                money.coins -= 250;
                money.UpdateCoins();
            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP4()
    {
        if (U4 == 0)
        {
            if (money.coins >= 250)
            {
                U4 = 1;
                money.coins -= 250;
                money.UpdateCoins();
            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP5()
    {
        if (U5 == 0)
        {
            if (money.coins >= 250)
            {
                U5 = 1;
                money.coins -= 250;
                money.UpdateCoins();
            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP6()
    {
        if (U6 == 0)
        {
            if (money.coins >= 400)
            {
                U6 = 1;
                money.coins -= 400;
                money.UpdateCoins();
            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP7()
    {
        if (U7 == 0)
        {
            if (money.coins >= 500)
            {
                U7 = 1;
                money.coins -= 500;
                money.UpdateCoins();
            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP8()
    {
        if (U8 == 0)
        {
            if (money.coins >= 700)
            {
                U8 = 1;
                money.coins -= 700;
                money.UpdateCoins();
            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP9()
    {
        if (U9 == 0)
        {
            if (money.coins >= 750)
            {
                U9 = 1;
                money.coins -= 750;
                money.UpdateCoins();
            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP10()
    {
        if (U10 == 0)
        {
            if (money.coins >= 750)
            {
                U10 = 1;
                money.coins -= 750;
                money.UpdateCoins();
            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP11()
    {
        if (U11 == 0)
        {
            if (money.coins >= 1500)
            {
                U11 = 1;
                money.coins -= 1500;
                money.UpdateCoins();
            }
            else
            {
                //play no money audio
            }
        }
    }


    //if uX ==0...----> else set colour darker <----

}