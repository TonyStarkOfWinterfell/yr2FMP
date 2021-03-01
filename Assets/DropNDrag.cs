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

        if(mouseButtonReleased && thisGameobjectName == "Red" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentObj--;
            buttonScript.buttonText.text = buttonScript.currentObj + "/6";
            Instantiate(Resources.Load("Orange_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            //destroying obj then using it
           
        }
        else if (mouseButtonReleased && thisGameobjectName == "Orange" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentObj--;
            buttonScript.buttonText.text = buttonScript.currentObj + "/6";
            Instantiate(Resources.Load("Yellow_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
        else if (mouseButtonReleased && thisGameobjectName == "Yellow" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentObj--;
            buttonScript.buttonText.text = buttonScript.currentObj + "/6";
            Instantiate(Resources.Load("Green_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
        else if (mouseButtonReleased && thisGameobjectName == "Green" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentObj--;
            buttonScript.buttonText.text = buttonScript.currentObj + "/6";
            Instantiate(Resources.Load("Blue_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
        else if (mouseButtonReleased && thisGameobjectName == "Blue" && thisGameobjectName == collisionGameobjectName)
        {
            buttonScript.currentObj--;
            buttonScript.buttonText.text = buttonScript.currentObj + "/6";
            Instantiate(Resources.Load("Purple_Object"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
    }







}
