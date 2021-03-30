using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{ 
    public float maxSize;
    public float currentTimer;
    public float waitTime;

    public float currentFood;

    public Transform scaled;

    public Kitty kitty;


    public void Start()
    {
        scaled = transform.Find("HealthBar/FillHold");
        kitty = gameObject.GetComponent<Kitty>();

        currentFood = 0.5f;

        StartCoroutine(Scale());

        switch (gameObject.tag)
        {
            case "K1":
                currentTimer = 0.1f; 
                break;
            case "K2":
                currentTimer = 0.17f;
                break;
            case "K3":
                currentTimer = 0.24f;
                break;
            case "K4":
                currentTimer = 0.31f;
                break;
            case "K5":
                currentTimer = 0.38f;
                break;
            case "K6":
                currentTimer = 0.45f;
                break;
            case "K7":
                currentTimer = 0.52f;
                break;
            case "K8":
                currentTimer = 0.59f;
                break;
            case "K9":
                currentTimer = 0f;
                break;
            default:
                Debug.Log("not sure what to do with this right now lol");
                break;
        }
    }

    public void Update()
    {
        if (scaled.transform.localScale.x <= 0)
        {
            kitty.isDead = true;
        }
        else
        {
            kitty.isDead = false;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetMaxHealth();
        }
    }




    public void SetMaxHealth()
    {
        scaled.transform.localScale = new Vector3(2.9f, scaled.transform.localScale.y, scaled.transform.localScale.z);
    }

    public void HealFood()
    {
        Debug.Log("Started food heal shiiiii");
        if (scaled.transform.localScale.x >= (2.9f - currentFood))
        {
            SetMaxHealth();
        }
        else if (scaled.transform.localScale.x < (2.9f - currentFood))
        {
            scaled.transform.localScale = new Vector3(scaled.transform.localScale.x + currentFood, scaled.transform.localScale.y, scaled.transform.localScale.z);
        }
        else
        {
            Debug.Log("FOOD ERROR");
        }
    }

    IEnumerator Scale()
    {
        float timer = 0;

        while (true)
        {
            // we scale all axis, so they will have the same value, 
            // so we can work with a float instead of comparing vectors
            /*while (maxSize > scaled.transform.localScale.x)
            {
                timer += Time.deltaTime;
                //scaled.transform.localScale += new Vector3(1 * Time.deltaTime * currentTimer, 0, 0);
                yield return null;
            }*/
            // reset the timer

            yield return new WaitForSeconds(waitTime);
            timer = 0;

            while (0 < scaled.transform.localScale.x)
            {
                timer += Time.deltaTime;
                scaled.transform.localScale -= new Vector3(1 * Time.deltaTime * currentTimer / 10, 0, 0);
                yield return null;
            }

            timer = 0;
            yield return new WaitForSeconds(waitTime);
        }
    }    
}
