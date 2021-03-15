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

    public GameObject manageHolder3;
    public Money money3;

    public GameObject shop;
    public GameObject vet;

    public GameObject spawnBox;

    private void Start()
    {
        spawnHolder = GameObject.FindGameObjectWithTag("SPHolder");
        buttonScript = spawnHolder.GetComponent<ButtonScript>();

        manageHolder3 = GameObject.FindGameObjectWithTag("Manager");
        money3 = manageHolder3.GetComponent<Money>();
    }

    public void OnMouseDown()
    {
        if(this.gameObject != shop || this.gameObject != vet)
        {
            mouseButtonReleased = false;
            offsetX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            offsetY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;

            
        }
        else
        {
            Debug.Log("clicked on shop");
        }
        
    }

    public void OnMouseDrag()
    {
        if(this.gameObject != shop || this.gameObject != vet)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - offsetX, mousePosition.y - offsetY);
        }
        else
        {
            Debug.Log("trna drag on on shop");
        }
    }

    public void OnMouseUp()
    {
        mouseButtonReleased = true;
    }



    public void OnTriggerStay2D(Collider2D collision)
    {
        string thisGameobjectName;
        string collisionGameobjectName;

        //give the value of collision object to the first character only VVV
        //also need name and "_Object"
        thisGameobjectName = gameObject.name.Substring(0, name.IndexOf("_"));
        collisionGameobjectName = collision.gameObject.name.Substring(0, name.IndexOf("_"));


               
       
        if (mouseButtonReleased && thisGameobjectName == "1" && thisGameobjectName == collisionGameobjectName)
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
                          


















        else if (mouseButtonReleased && collisionGameobjectName == "P")
        {
            buttonScript.currentCats--;
            buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;            
            mouseButtonReleased = false;

            

            switch (gameObject.tag)
            {
                case "K1":
                    money3.coins += 1;
                    break;
                case "K2":
                    money3.coins += 16;
                    break;
                case "K3":
                    money3.coins += 81;
                    break;
                case "K4":
                    money3.coins += 256;
                    break;
                case "K5":
                    money3.coins += 625;
                    break;
                case "K6":
                    money3.coins += 1296;
                    break;
                case "K7":
                    money3.coins += 2400;
                    break;
                case "K8":
                    money3.coins += 4850;
                    break;
                case "K9":
                    money3.coins += 10000;
                    break;
                default:
                    Debug.Log("not sure what to do with this right now lol");
                    break;
            }

            money3.UpdateCoins();

            Destroy(gameObject);
            //destroying obj then using it

        }


        else if (mouseButtonReleased && collisionGameobjectName == "V")
        {                       
            mouseButtonReleased = false;



            switch (gameObject.tag)
            {
                case "K1":
                    Instantiate(Resources.Load("1_Object"), spawnBox.transform.position, Quaternion.identity);
                    break;
                case "K2":
                    Instantiate(Resources.Load("2_Object"), transform.position, Quaternion.identity);
                    break;
                case "K3":
                    Instantiate(Resources.Load("3_Object"), transform.position, Quaternion.identity);
                    break;
                case "K4":
                    Instantiate(Resources.Load("4_Object"), transform.position, Quaternion.identity);
                    break;
                case "K5":
                    Instantiate(Resources.Load("5_Object"), transform.position, Quaternion.identity);
                    break;
                case "K6":
                    Instantiate(Resources.Load("6_Object"), transform.position, Quaternion.identity);
                    break;
                case "K7":
                    Instantiate(Resources.Load("7_Object"), transform.position, Quaternion.identity);
                    break;
                case "K8":
                    Instantiate(Resources.Load("8_Object"), transform.position, Quaternion.identity);
                    break;                
                default:
                    Debug.Log("not sure what to do with this right now lol");
                    break;
            }
            money3.coins -= 100;
            money3.UpdateCoins();

            Destroy(gameObject);
            //destroying obj then using it

        }



    }







}
