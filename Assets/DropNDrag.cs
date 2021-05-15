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

    public GameObject foodHolder;
    public AudioClip foodMunch;
    AudioSource foodSource;

    public GameObject shopHolder;
    public AudioClip shopBell;
    AudioSource shopSource;

    public bool sellDouble = false;

    public bool isDead;

    public GameObject healthBar;

    public GameObject shopSprite;
    public Animator shopAnim;
    private string currentState;
    const string SHOPIDLE = "ShopIdle";
    const string SHOPJIGGLE = "ShopJiggle";

    public GameObject currentClicked;

    public GameObject infoHolder;
    public InfoMenu infoMenu;

    private void Start()
    {
        if (gameObject.tag == "VetShop" || gameObject.tag == "PetShop")
        {
            shopSprite = transform.Find("Image").gameObject;
            shopAnim = shopSprite.GetComponent<Animator>();
        }
        spawnHolder = GameObject.FindGameObjectWithTag("SPHolder");
        buttonScript = spawnHolder.GetComponent<ButtonScript>();

        manageHolder3 = GameObject.FindGameObjectWithTag("Manager");
        money3 = manageHolder3.GetComponent<Money>();

        resetFood = GameObject.FindGameObjectWithTag("ResetFood");
        food = GameObject.FindGameObjectWithTag("Food");

        sprite = food.gameObject.GetComponent<SpriteRenderer>();
        
        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0f); 
        //future problem with cats autospawning and reseting mid drag VVVVVVV fix it by calling it in the start of another script that doesnt respawns
        food.transform.position = resetFood.transform.position;

        foodHolder = GameObject.FindGameObjectWithTag("FoodS");
        foodMunch = Resources.Load<AudioClip>("FoodSound");
        foodSource = foodHolder.GetComponent<AudioSource>();

        shopHolder = GameObject.FindGameObjectWithTag("ShopS");
        shopBell = Resources.Load<AudioClip>("hoverShop");
        shopSource = shopHolder.GetComponent<AudioSource>();

        infoHolder = GameObject.FindGameObjectWithTag("Info");
        infoMenu = infoHolder.GetComponent<InfoMenu>();

        isDead = false;

        if (gameObject.tag != "VetShop" && gameObject.tag != "PetShop" && gameObject.tag != "Food")
        {
            healthBar = transform.Find("HealthBar").gameObject;
            healthBar.SetActive(false);
        }

        
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            infoMenu.infoCat6 = true;
        }
    }
    public void OnMouseOver()
    {
        if (gameObject.tag != "VetShop" && gameObject.tag != "PetShop" && gameObject.tag != "Food")
        {
            healthBar.SetActive(true);
        }
    }
    public void OnMouseExit()
    {
        if (gameObject.tag != "VetShop" && gameObject.tag != "PetShop" && gameObject.tag != "Food")
        {
            healthBar.SetActive(false);
        }        
    }

    public void OnMouseDown()
    {
        currentClicked = this.gameObject;

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

        try
        {
            gameObject.GetComponent<Patrol>().refresh = true;
        }
        catch
        {
            
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
        if (gameObject.tag != "VetShop" && gameObject.tag != "PetShop")
        {
            StartCoroutine(Wait2());
        }        
        
        mouseButtonReleased = true;
        StartCoroutine(Wait());
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        string thisGameobjectName;
        string collisionGameobjectName;

        //give the value of collision object to the first character only VVV
        //also all names need to be 1 letter/number with "_Object"        
        thisGameobjectName = gameObject.name.Substring(0, name.IndexOf("_"));
        collisionGameobjectName = collision.gameObject.name.Substring(0, name.IndexOf("_"));

        

        if (gameObject.tag != "SPHolder" && collision.gameObject.tag != "SPHolder")
        {
            DropNDrag localDrag = collision.GetComponent<DropNDrag>();

            if (thisGameobjectName == "P" && collisionGameobjectName != "F" && localDrag.isDead == false)
            {
                shopSource.PlayOneShot(shopBell);
                shopAnim.Play(SHOPJIGGLE);
            }
            if (thisGameobjectName == "V" && collisionGameobjectName != "F" && localDrag.isDead == true)
            {
                shopSource.PlayOneShot(shopBell);
                shopAnim.Play(SHOPJIGGLE);
            }
        }        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        string thisGameobjectName;
        string collisionGameobjectName;

        //give the value of collision object to the first character only VVV
        //also all names need to be 1 letter/number with "_Object"        
        thisGameobjectName = gameObject.name.Substring(0, name.IndexOf("_"));
        collisionGameobjectName = collision.gameObject.name.Substring(0, name.IndexOf("_"));


        if (gameObject.tag != "SPHolder" && collision.gameObject.tag != "SPHolder")
        {
            DropNDrag localDrag2 = collision.GetComponent<DropNDrag>();

            if (thisGameobjectName == "P" && collisionGameobjectName != "F")
            {
                shopAnim.Play(SHOPIDLE);
            }
            if (thisGameobjectName == "V" && collisionGameobjectName != "F" && localDrag2.isDead == true)
            {
                shopAnim.Play(SHOPIDLE);
            }
        }        
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        string thisGameobjectName;
        string collisionGameobjectName;       

        //give the value of collision object to the first character only VVV
        //also all names need to be 1 letter/number with "_Object"        
        thisGameobjectName = gameObject.name.Substring(0, name.IndexOf("_"));
        collisionGameobjectName = collision.gameObject.name.Substring(0, name.IndexOf("_"));

        if (gameObject.tag != "SPHolder" && collision.gameObject.tag != "SPHolder")
        {
            DropNDrag otherDrag = collision.GetComponent<DropNDrag>();

            if (isDead == false && otherDrag.isDead == false)
            {
                if (mouseButtonReleased && thisGameobjectName == "1" && thisGameobjectName == collisionGameobjectName && this.gameObject == currentClicked)
                {
                    buttonScript.currentCats--;
                    buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
                    Instantiate(Resources.Load("2_Object"), transform.position, Quaternion.identity);
                    mouseButtonReleased = false;

                    if (infoMenu.infoCat2 == false)
                    {
                        infoMenu.infoCat2 = true;
                    }

                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                }
                else if (mouseButtonReleased && thisGameobjectName == "2" && thisGameobjectName == collisionGameobjectName)
                {
                    buttonScript.currentCats--;
                    buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
                    Instantiate(Resources.Load("3_Object"), transform.position, Quaternion.identity);
                    mouseButtonReleased = false;

                    if (infoMenu.infoCat3 == false)
                    {
                        infoMenu.infoCat3 = true;
                    }

                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                }
                else if (mouseButtonReleased && thisGameobjectName == "3" && thisGameobjectName == collisionGameobjectName)
                {
                    buttonScript.currentCats--;
                    buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
                    Instantiate(Resources.Load("4_Object"), transform.position, Quaternion.identity);
                    mouseButtonReleased = false;

                    if (infoMenu.infoCat4 == false)
                    {
                        infoMenu.infoCat4 = true;
                    }

                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                }
                else if (mouseButtonReleased && thisGameobjectName == "4" && thisGameobjectName == collisionGameobjectName)
                {
                    buttonScript.currentCats--;
                    buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
                    Instantiate(Resources.Load("5_Object"), transform.position, Quaternion.identity);
                    mouseButtonReleased = false;

                    if (infoMenu.infoCat5 == false)
                    {
                        infoMenu.infoCat5 = true;
                    }

                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                }
                else if (mouseButtonReleased && thisGameobjectName == "5" && thisGameobjectName == collisionGameobjectName)
                {
                    buttonScript.currentCats--;
                    buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
                    Instantiate(Resources.Load("6_Object"), transform.position, Quaternion.identity);
                    mouseButtonReleased = false;

                    if (infoMenu.infoCat6 == false)
                    {
                        infoMenu.infoCat6 = true;
                    }

                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                }
                else if (mouseButtonReleased && thisGameobjectName == "6" && thisGameobjectName == collisionGameobjectName)
                {
                    buttonScript.currentCats--;
                    buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
                    Instantiate(Resources.Load("7_Object"), transform.position, Quaternion.identity);
                    mouseButtonReleased = false;

                    if (infoMenu.infoCat7 == false)
                    {
                        infoMenu.infoCat7 = true;
                    }

                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                }
                else if (mouseButtonReleased && thisGameobjectName == "7" && thisGameobjectName == collisionGameobjectName)
                {
                    buttonScript.currentCats--;
                    buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
                    Instantiate(Resources.Load("8_Object"), transform.position, Quaternion.identity);
                    mouseButtonReleased = false;

                    if (infoMenu.infoCat8 == false)
                    {
                        infoMenu.infoCat8 = true;
                    }

                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                }
                else if (mouseButtonReleased && thisGameobjectName == "8" && thisGameobjectName == collisionGameobjectName)
                {
                    buttonScript.currentCats--;
                    buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
                    Instantiate(Resources.Load("9_Object"), transform.position, Quaternion.identity);
                    mouseButtonReleased = false;

                    if (infoMenu.infoCat9 == false)
                    {
                        infoMenu.infoCat9 = true;
                    }

                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                }





                else if (mouseButtonReleased && collisionGameobjectName == "P")
                {
                    buttonScript.currentCats--;
                    buttonScript.buttonText.text = buttonScript.currentCats + "/" + buttonScript.maxCats;
                    mouseButtonReleased = false;

                    otherDrag.shopAnim.Play(SHOPIDLE);

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
                    }
                }

                else if (mouseButtonReleased && thisGameobjectName == "F" && collisionGameobjectName != "P" && collisionGameobjectName != "V")
                {
                    mouseButtonReleased = false;
                    localHealth = collision.gameObject.GetComponent<Health>();

                    if (money3.coins >= 100)
                    {
                        localHealth.currentFood = 0.7f;

                        foodSource.PlayOneShot(foodMunch);

                        localHealth.HealFood();

                        money3.coins -= 100;
                        money3.UpdateCoins();
                    }
                }
            }
            else
            {
                if (mouseButtonReleased && collisionGameobjectName == "V")
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
                        otherDrag.shopAnim.Play(SHOPIDLE);
                        if (localHealth.scaled.transform.localScale.x <= 0)
                        {
                            if (money3.coins >= 500)
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
                                money3.coins -= 500;
                                money3.UpdateCoins();

                                Destroy(gameObject);
                            }
                        }
                    }
                }
            }
        }             
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.05f);

        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0f);
        food.transform.position = resetFood.transform.position;
    }

    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(0.05f);

        if (gameObject.transform.position.x > 4f)
        {
            gameObject.transform.position = new Vector3(3.25f, gameObject.transform.position.y, 0);
        }
        if (gameObject.transform.position.x < -2.85f)
        {
            gameObject.transform.position = new Vector3(-2.5f, gameObject.transform.position.y, 0);
        }
    }

    void ChangeAnimationState(string newState)
    {
        //stop same animation interupting
        if (currentState == newState) return;

        shopAnim.Play(newState);

        currentState = newState;
    }
}

