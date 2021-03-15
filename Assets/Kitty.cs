using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitty : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Health health;
    //--------------------
    public GameObject manageHolder2;
    public Money money2;

    public float waitTimer = 2.0f;
    public float currentTimer = 0.0f;


    public int autoMultiplier;


    public bool doublePassive = false;



    //seems to have individual generation. just need to figure out how to limit the update. maybe a loop with an if statement in the update.

    //need to add a variable to scale health deplete * delta.Time

    private void Start()
    {
        //currentHealth = maxHealth;
        //health.SetMaxHealth(maxHealth);
        //if wosrt comes to worst and theyre not individual. then just do generate money x number of cats with ""level x name""

        manageHolder2 = GameObject.FindGameObjectWithTag("Manager");
        money2 = manageHolder2.GetComponent<Money>();

       

        //on thingy spawned

        switch (gameObject.tag)
        {
            case "K1":
                autoMultiplier = 2;
                break;
            case "K2":
                autoMultiplier = 6;
                break;
            case "K3":
                autoMultiplier = 12;
                break;
            case "K4":
                autoMultiplier = 24;
                break;
            case "K5":
                autoMultiplier = 48;
                break;
            case "K6":
                autoMultiplier = 96;
                break;
            case "K7":
                autoMultiplier = 192;
                break;
            case "K8":
                autoMultiplier = 384;
                break;
            case "K9":
                autoMultiplier = 768;
                break;
            default:
                Debug.Log("not sure what to do with this right now lol");
                break;
        }

    }

    private void Update()
    {
        /*
        //replace this with remove over time x 1.x x being bigger or smaller per level
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }*/




        currentTimer += Time.deltaTime;


        if(currentTimer >= waitTimer)
        {
            currentTimer = 0.0f;
            StartCoroutine(AutoGenerate());
        }                   
    }

    IEnumerator AutoGenerate()
    {        
        yield return new WaitForSeconds(2);
        
        if(doublePassive == true)
        {
            money2.coins += autoMultiplier * 1.5;
            money2.UpdateCoins();
        }
        else
        {
            money2.coins += autoMultiplier;
            money2.UpdateCoins();
        }          
    }

    /*
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        health.SetHealth(currentHealth);
    }*/





    

}
