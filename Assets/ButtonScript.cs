using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public int maxVal;
    public int maxCats;

    public int currentVal;
    public int currentCats;
    public int currentClick;
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

    public Text buttonText;

    public Vector3 centre;
    public Vector3 size;


    //revamp button to add percentage out of 150.   for autofill- increase+1.deltaTime times ?

    public void Start()
    {
        maxVal = 150;
        maxCats = 5;

        currentVal = 0;
        currentCats = 0;
        currentClick = 10; //15 clicks to fill
        currentSpawn = lvl1;
    }

    

    public void OnMouseDown()
    {
        PushyButton();        
    }

    public void PushyButton()
    {
        
        //main button press. add vertical slider here.
        if (currentVal >= maxVal)
        {
            SpawnObject();
            currentVal = 0;            
        }
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
    

