﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Upgrades : MonoBehaviour
{
    public GameObject manageHolder;
    public Money money;
    public Kitty kitty;

    public GameObject mainButtonHolder;
    public ButtonScript mainClick;

    public GameObject sellHolder;
    public DropNDrag sell;

    public GameObject currentButton;
    public GameObject buttonBlack;
    public Image blackImage;
    //public GameObject testButt;
    //dont send to a variable that doesnt exist. get the new spawned variable to call from a static holder

    public GameObject scoreHolder;
    public DontDestroy dontDestroy;

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
    private int U12 = 0;
    private int U13 = 0;
    private int U14 = 0;
    private int U15 = 0;
    private int U16 = 0;
    private int U17 = 0;
    private int U18 = 0;
    private int U19 = 0;
    private int U20 = 0;
    private int U21 = 0;
    private int U22 = 0;
    private int U23 = 0;
    private int U24 = 0;
    private int U25 = 0;

    private void Start()
    {
        manageHolder = GameObject.FindGameObjectWithTag("Manager");
        money = manageHolder.GetComponent<Money>();
        kitty = manageHolder.GetComponent<Kitty>();

        mainButtonHolder = GameObject.FindGameObjectWithTag("SPHolder");
        mainClick = mainButtonHolder.GetComponent<ButtonScript>();

        sellHolder = GameObject.FindGameObjectWithTag("PetShop");
        sell = sellHolder.GetComponent<DropNDrag>();

        scoreHolder = GameObject.FindGameObjectWithTag("Cross");
        dontDestroy = scoreHolder.gameObject.GetComponent<DontDestroy>();
    }

    public void AddMoney()
    {
        money.coins += 50;        
        money.UpdateCoins();
    }
    /*
    public void TestScor()
    {
        dontDestroy.currentMoney = money.coins;
        Debug.Log("succc");
        SceneManager.LoadScene("HighScore");
    }*/

    public void UP1()
    {
        if (U1 == 0)
        {
            if (money.coins >= 15)
            {
                //testButt = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
                U1 = 1;
                money.coins -= 15;
                money.UpdateCoins();
                
                mainClick.currentClick = 15;

                currentButton = EventSystem.current.currentSelectedGameObject; 

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);
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

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

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

                kitty.doublePassive = true;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

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

                mainClick.currentClick = 30;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

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

                mainClick.currentFPS = 35;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

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

                mainClick.maxCats = 6;
                mainClick.buttonText.text = mainClick.currentCats + "/" + mainClick.maxCats;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

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

                sell.sellDouble = true;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

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

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

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

                mainClick.currentFPS = 75;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

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

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

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

                mainClick.currentSpawn = mainClick.lvl2;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP12()
    {
        if (U12 == 0)
        {
            if (money.coins >= 1300)
            {
                U12 = 1;
                money.coins -= 1300;
                money.UpdateCoins();

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP13()
    {
        if (U13 == 0)
        {
            if (money.coins >= 1300)
            {
                U13 = 1;
                money.coins -= 1300;
                money.UpdateCoins();

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP14()
    {
        if (U14 == 0)
        {
            if (money.coins >= 1300)
            {
                U14 = 1;
                money.coins -= 1300;
                money.UpdateCoins();

                mainClick.currentFPS = 100;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP15()
    {
        if (U15 == 0)
        {
            if (money.coins >=2500)
            {
                U15 = 1;
                money.coins -= 2500;
                money.UpdateCoins();

                mainClick.maxCats = 9;
                mainClick.buttonText.text = mainClick.currentCats + "/" + mainClick.maxCats;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP16()
    {
        if (U16 == 0)
        {
            if (money.coins >= 3000)
            {
                U11 = 1;
                money.coins -= 3000;
                money.UpdateCoins();

                mainClick.currentSpawn = mainClick.lvl3;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP17()
    {
        if (U17 == 0)
        {
            if (money.coins >= 3000)
            {
                U17 = 1;
                money.coins -= 3000;
                money.UpdateCoins();

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP18()
    {
        if (U18 == 0)
        {
            if (money.coins >= 3500)
            {
                U18 = 1;
                money.coins -= 3500;
                money.UpdateCoins();

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP19()
    {
        if (U19 == 0)
        {
            if (money.coins >= 5000)
            {
                U19 = 1;
                money.coins -= 5000;
                money.UpdateCoins();

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP20()
    {
        if (U20 == 0)
        {
            if (money.coins >= 8000)
            {
                U20 = 1;
                money.coins -= 8000;
                money.UpdateCoins();

                mainClick.currentSpawn = mainClick.lvl4;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP21()
    {
        if (U21 == 0)
        {
            if (money.coins >= 10000)
            {
                U21 = 1;
                money.coins -= 10000;
                money.UpdateCoins();

                mainClick.currentSpawn = mainClick.lvl5;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP22()
    {
        if (U22 == 0)
        {
            if (money.coins >= 15000)
            {
                U22 = 1;
                money.coins -= 15000;
                money.UpdateCoins();

                mainClick.currentSpawn = mainClick.lvl6;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP23()
    {
        if (U23 == 0)
        {
            if (money.coins >= 30000)
            {
                U23 = 1;
                money.coins -= 30000;
                money.UpdateCoins();

                mainClick.currentSpawn = mainClick.lvl7;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP24()
    {
        if (U24 == 0)
        {
            if (money.coins >= 60000)
            {
                U24 = 1;
                money.coins -= 60000;
                money.UpdateCoins();

                mainClick.currentSpawn = mainClick.lvl8;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                Destroy(currentButton);

            }
            else
            {
                //play no money audio
            }
        }
    }
    public void UP25()
    {
        if (U25 == 0)
        {
            if (money.coins >= 100000)
            {
                U25 = 1;
                money.coins -= 100000;
                money.UpdateCoins();

                mainClick.currentSpawn = mainClick.lvl9;

                currentButton = EventSystem.current.currentSelectedGameObject;

                buttonBlack = currentButton.transform.Find("Black").gameObject;
                blackImage = buttonBlack.GetComponent<Image>();
                blackImage.color = new Color(0f, 0f, 0f, 0.5f);

                dontDestroy.currentMoney = money.coins;                
                SceneManager.LoadScene("HighScore");


            }
            else
            {
                //play no money audio
            }
        }
    }



    //if uX ==0...----> else set colour darker <----

}