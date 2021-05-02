using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public int maxVal;
    public int maxCats;
    //if current cats > 0 random play meow -- 20 secs/
    public double currentVal;
    public int currentCats;
    public int currentClick;

    public double currentFPS; //fill per second
    public bool ifAuto;

    public GameObject currentSpawn;    
        
    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lvl3;
    public GameObject lvl4;
    public GameObject lvl5;
    public GameObject lvl6;
    public GameObject lvl7;
    public GameObject lvl8;
    public GameObject lvl9;

    public Slider autoFill;

    public int maxFill;
    public int currentFill;

    public Text buttonText;

    public Vector3 centre;
    public Vector3 size;

    public Animator anim;

    const string IDLE = "Idle";
    const string BUTTONPOP = "ButtonPop";

    public GameObject buttonHolder;
    public AudioClip buttonClick;
    AudioSource buttonSource;

    public GameObject slider;
    public GameObject resetHolder;
    public RectTransform resetPos;
    public RectTransform sliderPos;

    public bool mergeCheck;

    public GameObject popUpHolder;
    public PopUpSys popUpScript;
    
    //update. if false > if current cats >= 2 debug.Log replace for set value in other script > set can merge true

    public void Start()
    {
        anim = GetComponent<Animator>();

        buttonSource = buttonHolder.GetComponent<AudioSource>();

        slider = GameObject.FindGameObjectWithTag("Slider");
        resetHolder = GameObject.FindGameObjectWithTag("ResetSlide");
        resetPos = resetHolder.GetComponent<RectTransform>();
        sliderPos = slider.GetComponent<RectTransform>();


        maxVal = 150;
        maxCats = 5;

        currentFPS = 0;
        ifAuto = false;

        currentVal = 0;
        currentCats = 0;
        currentClick = 10;
        currentSpawn = lvl1;

        mergeCheck = false;

        popUpHolder = GameObject.FindGameObjectWithTag("Manager");
        popUpScript = popUpHolder.GetComponent<PopUpSys>();

    }

    public void Update()
    {
        sliderPos = resetPos;

        SetFill(currentVal);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeAnimationState(BUTTONPOP);
        }

        if (ifAuto == true)
        {
            currentVal += currentFPS * Time.deltaTime;
        }

        if (mergeCheck == false)
        {
            if(currentCats >= 2)
            {
                popUpScript.hasMerged = true;
                
                mergeCheck = true;
            }
        }
    }

    public void SetFill(double fill)
    {
        //fill = currentVal;
        autoFill.value = (float)fill;
    }

    public void OnMouseDown()
    {
        ChangeAnimationState(BUTTONPOP);
        buttonSource.PlayOneShot(buttonClick);
        PushyButton();        
    }

    public void OnMouseUp()
    {
        ChangeAnimationState(IDLE);        
    }

    public void PushyButton()
    {
        //animator.Play("ButtonPop");



        //need to take spawn code out of pushing button
        if (currentVal >= maxVal)
        {
            SpawnObject();
            currentVal = 0;            
        }
        //add if statement upwards saying if current cats is >= max cats then dont spawn. check whether up or dwn add also check it doesnt increase
        else
        {
            currentVal += currentClick;            
        }        
    }


    public void SpawnObject()
    {
        Vector3 pos = centre + new Vector3(Random.Range(-2.5f, 3.25f), Random.Range(-size.y / 2, size.y / 2), 50);
        if (currentCats < maxCats)
        {
            //switch lvl1 with new varient called currentLvl;
            Instantiate(currentSpawn, pos, Quaternion.identity);
            currentCats++;
            buttonText.text = currentCats + "/" + maxCats;

        }
        else
        {
            Debug.Log("Max objs");
        }

    }

    void ChangeAnimationState(string newState)
    {
        //stop same animation interupting
        //if (currentState == newStat) return;

        anim.Play(newState);
    }




}
    

