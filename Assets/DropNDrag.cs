using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropNDrag : MonoBehaviour
{ 
    private Vector2 mousePosition;
    private float offsetX, offsetY;
    public static bool mouseButtonReleased;

    public GameObject spawnHolder;
    public ButtonScript buttonScript;


    private void Start()
    {
        spawnHolder = GameObject.FindGameObjectWithTag("SPHolder");
        buttonScript = spawnHolder.GetComponent<ButtonScript>();
    }

    public void OnMouseDown()
    {
        mouseButtonReleased = false;
        offsetX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        offsetY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    public void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - offsetX, mousePosition.y - offsetY);
    }

    public void OnMouseUp()
    {
        mouseButtonReleased = true;
    }



    public void OnTriggerStay2D(Collider2D collision)
    {
        string thisGameobjectName;
        string collisionGameobjectName;

        thisGameobjectName = gameObject.name.Substring(0, name.IndexOf("_"));
        collisionGameobjectName = collision.gameObject.name.Substring(0, name.IndexOf("_"));

        if(mouseButtonReleased && thisGameobjectName == "1" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentCats--;
            buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
            Instantiate(Resources.Load("2_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            //destroying obj then using it
           
        }
        else if (mouseButtonReleased && thisGameobjectName == "2" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentCats--;
            buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
            Instantiate(Resources.Load("3_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
        else if (mouseButtonReleased && thisGameobjectName == "3" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentCats--;
            buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
            Instantiate(Resources.Load("4_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
        else if (mouseButtonReleased && thisGameobjectName == "4" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentCats--;
            buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
            Instantiate(Resources.Load("5_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
        else if (mouseButtonReleased && thisGameobjectName == "5" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentCats--;
            buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
            Instantiate(Resources.Load("6_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
        else if (mouseButtonReleased && thisGameobjectName == "6" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentCats--;
            buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
            Instantiate(Resources.Load("7_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
        else if (mouseButtonReleased && thisGameobjectName == "7" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentCats--;
            buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
            Instantiate(Resources.Load("8_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
        else if (mouseButtonReleased && thisGameobjectName == "8" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentCats--;
            buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
            Instantiate(Resources.Load("9_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }

    }







}
