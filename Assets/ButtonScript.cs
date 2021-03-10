﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public int clickFill;
    //public Slider autoFill;
    public int maxCats;

    public int maxObj = 6;
    public int currentObj = 0;

    public int loop;

    public GameObject lvl1;

    public Text buttonText;

    public Vector3 centre;
    public Vector3 size;


    //revamp button to add percentage out of 100. +20+10+5.    for autofill- increase+1.deltaTime times ?

    public void Start()
    {
        loop = 0;
    }

    

    public void OnMouseDown()
    {
        PushyButton();        
    }

    public void PushyButton()
    {
        

        //main button press. add vertical slider here.
        if (loop == 5)
        {
            SpawnObject();
            loop = 0;
            //Debug.Log("loop = " + loop);
        }
        else
        {
            loop++;
            //Debug.Log("loop = " + loop);
        }
    }


    public void SpawnObject()
    {
        Vector3 pos = centre + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), 0);
        if (currentObj < maxObj)
        {
            Instantiate(lvl1, pos, Quaternion.identity);
            currentObj++;
            buttonText.text = currentObj + "/6";

        }
        else
        {
            Debug.Log("Max objs");
        }

    }






}
    

