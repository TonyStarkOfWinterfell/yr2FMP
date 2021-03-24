﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public int maxVal;
    public int maxCats;

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

    private Animator anim;

    //revamp button to add percentage out of 150.   for autofill- increase+1.deltaTime times ? 
    // ^^ done

    public void Start()
    {
        anim = gameObject.GetComponent<Animator>();

        maxVal = 150;
        maxCats = 5;

        currentFPS = 0;
        ifAuto = false;

        currentVal = 0;
        currentCats = 0;
        currentClick = 10; //15 clicks to fill
        currentSpawn = lvl1;
    }

    public void Update()
    {
        SetFill(currentVal);


        if(ifAuto == true)
        {
            currentVal += currentFPS * Time.deltaTime;
        }
    }

    public void SetFill(double fill)
    {
        //fill = currentVal;
        autoFill.value = (float)fill;
    }

    public void OnMouseDown()
    {
        PushyButton();        
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
        Vector3 pos = centre + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), 0);
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






}
    

