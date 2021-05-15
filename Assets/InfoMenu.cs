using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InfoMenu : MonoBehaviour
{
    public GameObject onScreen;
    public GameObject offScreen;

    public GameObject upgradeMenu;
    public GameObject infoMenu;

    public Animator anim;

    const string BOOKIDLE = "BookIdle";
    const string BOOKOPEN = "BookOpen";
    private bool isBook;

    public GameObject buttonHolder;
    public AudioClip buttonClick;
    AudioSource buttonSource;



    public bool infoCat1 = false;
    public bool infoCat2 = false;
    public bool infoCat3 = false;
    public bool infoCat4 = false;
    public bool infoCat5 = false;
    public bool infoCat6 = false;
    public bool infoCat7 = false;
    public bool infoCat8 = false;
    public bool infoCat9 = false;

    public GameObject infoCatGO1;
    public GameObject infoCatGO2;
    public GameObject infoCatGO3;
    public GameObject infoCatGO4;
    public GameObject infoCatGO5;
    public GameObject infoCatGO6;
    public GameObject infoCatGO7;
    public GameObject infoCatGO8;
    public GameObject infoCatGO9;

    public GameObject currentInfoCat;

    public GameObject spriteGO;
    public GameObject levelGO;
    public GameObject cpsGO;
    public GameObject sellGO;

    public Image sprite;
    public Text level;
    public Text cps;
    public Text sell;
   

    void Start()
    {
        anim = GetComponent<Animator>();

        buttonSource = buttonHolder.GetComponent<AudioSource>();

        isBook = false;
        upgradeMenu.transform.position = onScreen.transform.position;
        infoMenu.transform.position = offScreen.transform.position;

        
    }

    //set true, current cat == this

    private void Update()
    {



         if (infoCat9 == true)
        {
            currentInfoCat = infoCatGO9;
            UpdateCurrentCat();

            sprite.color = new Color(255f, 255f, 255f, 1f);
            level.text = "LVL 9";
            cps.text = "CPS: 768";
            sell.text = "SELL: 10,000";
        }

        else if (infoCat8 == true)
        {
            currentInfoCat = infoCatGO8;
            UpdateCurrentCat();

            sprite.color = new Color(255f, 255f, 255f, 1f);
            level.text = "LVL 8";
            cps.text = "CPS: 384";
            sell.text = "SELL: 4850";
        }

        else if (infoCat7 == true)
        {
            currentInfoCat = infoCatGO7;
            UpdateCurrentCat();

            sprite.color = new Color(255f, 255f, 255f, 1f);
            level.text = "LVL 7";
            cps.text = "CPS: 192";
            sell.text = "SELL: 2400";
        }

        else if (infoCat6 == true)
        {
            currentInfoCat = infoCatGO6;
            UpdateCurrentCat();

            sprite.color = new Color(255f, 255f, 255f, 1f);
            level.text = "LVL 6";
            cps.text = "CPS: 96";
            sell.text = "SELL: 1296";
        }

        else if (infoCat5 == true)
        {
            currentInfoCat = infoCatGO5;
            UpdateCurrentCat();

            sprite.color = new Color(255f, 255f, 255f, 1f);
            level.text = "LVL 5";
            cps.text = "CPS: 48";
            sell.text = "SELL: 625";
        }

        else if (infoCat4 == true)
        {
            currentInfoCat = infoCatGO4;
            UpdateCurrentCat();

            sprite.color = new Color(255f, 255f, 255f, 1f);
            level.text = "LVL 4";
            cps.text = "CPS: 24";
            sell.text = "SELL: 256";
        }


        else if (infoCat3 == true)
        {
            currentInfoCat = infoCatGO3;
            UpdateCurrentCat();

            sprite.color = new Color(255f, 255f, 255f, 1f);
            level.text = "LVL 3";
            cps.text = "CPS: 12";
            sell.text = "SELL: 81";
        }


        else if (infoCat2 == true)
        {
            currentInfoCat = infoCatGO2;
            UpdateCurrentCat();

            sprite.color = new Color(255f, 255f, 255f, 1f);
            level.text = "LVL 2";
            cps.text = "CPS: 6";
            sell.text = "SELL: 16";
        }


        else if (infoCat1 == true)
        {
            currentInfoCat = infoCatGO1;
            UpdateCurrentCat();

            sprite.color = new Color(255f, 255f, 255f, 1f);
            level.text = "LVL 1";
            cps.text = "CPS: 2";
            sell.text = "SELL: 1";
        }
        
        
       
       
        else 
        {
            sprite.color = new Color(0f, 0f, 0f, 1f);
            level.text = "??";
            cps.text = "???";
            sell.text = "????";

            Debug.Log("spooky else");
        }
    }

    public void OnMouseDown()
    {
        if (isBook == true)
        {
            ChangeAnimationState(BOOKIDLE);
            buttonSource.PlayOneShot(buttonClick);

            upgradeMenu.transform.position = onScreen.transform.position;
            infoMenu.transform.position = offScreen.transform.position;

            isBook = false;
        }
        else
        {
            ChangeAnimationState(BOOKOPEN);
            buttonSource.PlayOneShot(buttonClick);

            upgradeMenu.transform.position = offScreen.transform.position;
            infoMenu.transform.position = onScreen.transform.position;

            isBook = true;

        }



    }

    void UpdateCurrentCat()
    {
        spriteGO = currentInfoCat.transform.Find("lvlSprite").gameObject;
        levelGO = currentInfoCat.transform.Find("lvlText").gameObject;
        cpsGO = currentInfoCat.transform.Find("cpsText").gameObject;
        sellGO = currentInfoCat.transform.Find("sellText").gameObject;

        sprite = spriteGO.GetComponent<Image>();
        level = levelGO.GetComponent<Text>();
        cps = cpsGO.GetComponent<Text>();
        sell = sellGO.GetComponent<Text>();
    }

    void ChangeAnimationState(string newState)
    {
        //stop same animation interupting
        //if (currentState == newStat) return;

        anim.Play(newState);
    }
}
