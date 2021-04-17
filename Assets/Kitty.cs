using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitty : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Health health;

    public bool isDead;
    //--------------------
    public GameObject manageHolder2;
    public Money money2;

    public float waitTimer = 2.0f;
    public float currentTimer = 0.0f;
    
    public int autoMultiplier;

    public bool doublePassive = false;

    

    private void Start()
    {
        manageHolder2 = GameObject.FindGameObjectWithTag("Manager");
        money2 = manageHolder2.GetComponent<Money>();

        //health = gameObject.GetComponent<Health>();

        isDead = false;
        
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
                //
                break;
        }

    }

    public void Update()
    {
        currentTimer += Time.deltaTime;

        if (isDead == false)
        {
            if (currentTimer >= waitTimer)
            {
                currentTimer = 0.0f;
                StartCoroutine(AutoGenerate());
            }
        }             
    }

    IEnumerator AutoGenerate()
    {        
        //might not need to wait for this as wait is in update.
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
}
