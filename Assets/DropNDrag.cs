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
    public GameObject food;

    public GameObject resetFood;

    public SpriteRenderer sprite;

    public Health localHealth;

    //public GameObject spawnBox;    

    public bool sellDouble = false;

    private void Start()
    {
        spawnHolder = GameObject.FindGameObjectWithTag("SPHolder");
        buttonScript = spawnHolder.GetComponent<ButtonScript>();

        manageHolder3 = GameObject.FindGameObjectWithTag("Manager");
        money3 = manageHolder3.GetComponent<Money>();

        resetFood = GameObject.FindGameObjectWithTag("ResetFood");
        food = GameObject.FindGameObjectWithTag("Food");

        sprite = food.gameObject.GetComponent<SpriteRenderer>();
        
        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0f); 
        //future problem with cats autospawning VVVVVVV
        food.transform.position = resetFood.transform.position;
    }
    public void OnMouseDown()
    {
        if(this.gameObject != shop && this.gameObject != vet)
        {
            if (this.gameObject == food)
            {
                sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1f);
            }
            mouseButtonReleased = false;
            offsetX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            offsetY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;            
        }                        
    }
    public void OnMouseDrag()
    {
        if(this.gameObject != shop && this.gameObject != vet)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - offsetX * 0, mousePosition.y - offsetY * 0);
        }
        if (this.gameObject == food)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1f);
        }
    }

    public void OnMouseUp()
    {
        mouseButtonReleased = true;
        StartCoroutine(Wait());
    }
    
    public void OnTriggerStay2D(Collider2D collision)
    {
        string thisGameobjectName;
        string collisionGameobjectName;       

        //give the value of collision object to the first character only VVV
        //also all names need to be 1 letter/number with "_Object"        
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

            if (thisGameobjectName == "F")
            {
                //sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0f);
                food.transform.position = resetFood.transform.position;
            }
            else
            {
                if (sellDouble == true)
                {
                    switch (gameObject.tag)
                    {
                        case "K1":
                            money3.coins += 1;
                            break;
                        case "K2":
                            money3.coins += 16 * 2;
                            break;
                        case "K3":
                            money3.coins += 81 * 2;
                            break;
                        case "K4":
                            money3.coins += 256 * 2;
                            break;
                        case "K5":
                            money3.coins += 625 * 2;
                            break;
                        case "K6":
                            money3.coins += 1296 * 2;
                            break;
                        case "K7":
                            money3.coins += 2400 * 2;
                            break;
                        case "K8":
                            money3.coins += 4850 * 2;
                            break;
                        case "K9":
                            money3.coins += 10000 * 2;
                            break;
                        default:
                            Debug.Log("not sure what to do with this right now lol");
                            break;
                    }
                }
                else
                {
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
                }


                money3.UpdateCoins();

                Destroy(gameObject);
                //destroying obj then using it
            }
        }       
        else if (mouseButtonReleased && collisionGameobjectName == "V")
        {                       
            mouseButtonReleased = false;

            if (thisGameobjectName == "F")
            {
                sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0f); 
                food.transform.position = resetFood.transform.position;
            }
            else
            {
                localHealth = this.gameObject.GetComponent<Health>();

                if (localHealth.scaled.transform.localScale.x <= 0)
                {
                    if (money3.coins >= 100)
                    {
                        switch (gameObject.tag)
                        {
                            case "K1":
                                Instantiate(Resources.Load("1_Object"), transform.position, Quaternion.identity);
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
                    }
                }                                
            }           
        }        
        else if (mouseButtonReleased && thisGameobjectName == "F" && collisionGameobjectName != "P" && collisionGameobjectName != "V")
        {
            mouseButtonReleased = false;
            localHealth = collision.gameObject.GetComponent<Health>();

            localHealth.currentFood = 1.45f;
            Debug.Log("passed health assign");

            localHealth.HealFood();

            Debug.Log("healthfood should be called");

        }
    }

    IEnumerator Wait()
    {
        yield return 20;

        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0f);
        food.transform.position = resetFood.transform.position;
    }
}

