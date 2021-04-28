using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpSys : MonoBehaviour
{
    public GameObject popUpBox;
    public Text popUpText;
    public string popText;

    public string currentOK;

    public bool hasMerged;                     
                                               
    public bool mergeOK;            
    public bool hasMoney;                    //change from button to on mouse down for sfx

    public bool foodOK;
    public bool isSick;

    public bool mergeBreak;
    public bool upgradeBreak;
    public bool vetBreak;

    public GameObject sfxHolder;
    public AudioClip sfxClip;
    AudioSource sfxSource;

    public Pause pause;
    public GameObject canvas;

    public void Start()
    {
       
        canvas = GameObject.FindGameObjectWithTag("Canv");
        pause = canvas.GetComponent<Pause>();

        pause.Paused();

        currentOK = "START";
        popText = "WELCOME TO\nPAWSITIVELY PURRFECT";

        hasMerged = false;

        mergeOK = false;
        hasMoney = false;

        foodOK = false;
        isSick = false;

        mergeBreak = false;
        upgradeBreak = false;
        vetBreak = false;

        sfxSource = sfxHolder.GetComponent<AudioSource>();
    }

    public void Update()
    {
        //if bool true then > PopUp("");
        //add this to events. once gotten then set this script thing to something.

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            PopUp("it worked");
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            hasMerged = true;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            mergeOK = true;
            hasMoney = true;
        }*/

        if (mergeBreak == false)
        {
            if (hasMerged == true)
            {
                PopUp("WELL DONE, YOU HAVE SOME\nLOCAL STRAYS! SUCH RASCALS!");
                currentOK = "MERG1";

                mergeBreak = true;
                pause.Paused();
            }
        }

        if (upgradeBreak == false)
        {
            if (mergeOK == true && hasMoney == true)
            {
                PopUp("YOU CAN UNLOCK AN UPGRADE ON THE\nRIGHT PANEL, THEY WILL SURELY HELP\nIN YOUR ADVENTURES");
                currentOK = "UPGRADE";

                upgradeBreak = true;
                pause.Paused();
            }
        }

        if (vetBreak == false)
        {
            if (foodOK == true && isSick == true)
            {
                PopUp("SICK CATS CAN'T BREED OR GENERATE\nINCOME! DRAG THE GREEN TINTED CATS TO\nTHE VET ON THE LEFT SIDE\n TO HEAL IT FOR £500!");
                currentOK = "VET";

                vetBreak = true;
                pause.Paused();
            }
        }

    }

    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUpText.text = text;
        //potential animation addition
    }

    public void OK()
    {      
        sfxSource.PlayOneShot(sfxClip);
        //can add you win here or last upgrade

        switch (currentOK)
        {
            case "START":
                PopUp("YOU HAVE RECENTLY FOUND YOUR\nPASSION AS A CAT BREEDER!\nIT'S TIME TO MAKE A FUR-TUNE");
                currentOK = "INTRO1"; 
                break;
            case "INTRO1":
                PopUp("START BY CLICKING ON THE\nPAW IN THE TOP LEFT CORNER\nTO ATTRACT SOME CATS!");
                currentOK = "INTRO2";
                break;
            case "INTRO2":
                popUpBox.SetActive(false);
                pause.Resume();
                break;
         //=====================\\         
            case "MERG1":
                PopUp("NOW IT'S TIME FOR YOUR FIRST BREED!\nBY BREEDING TWO OF THE SAME\nCATS YOU IMPROVE THEIR CUTENESS");
                currentOK = "MERG2";
                break;
            case "MERG2":
                PopUp("CUTER CATS WILL EARN MORE\nMONEY BOTH PASSIVELY AND\nWHEN SOLD TO THE PET\nSHOP IN THE TOP LEFT");
                currentOK = "MERG3";
                break;
            case "MERG3":
                popUpBox.SetActive(false);
                mergeOK = true;
                pause.Resume();
                break;
         //=====================\\     
            case "UPGRADE":
                PopUp("BELOW YOUR UPGRADES IS\nA PLACE TO BUY FOOD, EACH\nCOSTING £100. MAKE SURE TO\nFEED YOUR CATS IF\nTHEY GET LOW ON HEALTH!");
                currentOK = "FOOD";
                break;
            case "FOOD":
                popUpBox.SetActive(false);
                foodOK = true;
                pause.Resume();
                break;               
         //=====================\\     
            case "VET":
                popUpBox.SetActive(false);
                pause.Resume();
                break;
            default:
                PopUp("eRR0r so\nme\nwhe\nre");
                break;
        }
    }
}
