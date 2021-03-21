using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    
    

    public float maxSize;
    public float currentTimer;
    public float waitTime;

    public Transform scaled;

    public void Start()
    {
        scaled = transform.Find("HealthBar/FillHold");

        //SetMaxHealth();

        StartCoroutine(Scale());

        switch (gameObject.tag)
        {
            case "K1":
                currentTimer = 1.0f; 
                break;
            case "K2":
                currentTimer = 5.0f;
                break;
            case "K3":
                currentTimer = 100.0f;
                break;
            case "K4":
                currentTimer = 1.0f;
                break;
            case "K5":
                currentTimer = 1.0f;
                break;
            case "K6":
                currentTimer = 1.0f;
                break;
            case "K7":
                currentTimer = 1.0f;
                break;
            case "K8":
                currentTimer = 1.0f;
                break;
            case "K9":
                currentTimer = 1.0f;
                break;
            default:
                Debug.Log("not sure what to do with this right now lol");
                break;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetMaxHealth();
        }
    }




    public void SetMaxHealth()
    {
        scaled.transform.localScale = new Vector3(2.9f, scaled.transform.localScale.y, scaled.transform.localScale.z);
    }

    IEnumerator Scale()
    {
        float timer = 0;

        while (true)
        {
            // we scale all axis, so they will have the same value, 
            // so we can work with a float instead of comparing vectors
            while (maxSize > scaled.transform.localScale.x)
            {
                timer += Time.deltaTime;
                scaled.transform.localScale += new Vector3(1 * Time.deltaTime * currentTimer, 0, 0);
                yield return null;
            }

            // reset the timer
            yield return new WaitForSeconds(waitTime);

            timer = 0;
            while (0 < scaled.transform.localScale.x)
            {
                timer += Time.deltaTime;
                scaled.transform.localScale -= new Vector3(1 * Time.deltaTime * currentTimer, 0, 0);
                yield return null;
            }

            timer = 0;
            yield return new WaitForSeconds(waitTime);
        }
    }    
}
