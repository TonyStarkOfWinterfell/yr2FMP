using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZFix : MonoBehaviour
{

    public float currentXPosition;

    private GameObject cspriteGO;
    private SpriteRenderer csprite;

    private bool mouseDown;

    void Awake()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 50);        
    }

    void Start()
    {
        cspriteGO = transform.Find("CSprite").gameObject;
        csprite = cspriteGO.GetComponent<SpriteRenderer>();

        transform.position = new Vector3(transform.position.x, transform.position.y, 50);

        currentXPosition = transform.position.x;

    }

    public void OnMouseDown()
    {
        gameObject.GetComponent<ZFix>().mouseDown = true;
    }
    public void OnMouseUp()
    {
        gameObject.GetComponent<ZFix>().mouseDown = false;
    }



    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 50);

        if (mouseDown == false)
        {
            if (transform.position.x < currentXPosition)
            {
                csprite.flipX = true;
                currentXPosition = transform.position.x;
            }
            else
            {
                csprite.flipX = false;
                currentXPosition = transform.position.x;
            }
        }
        else
        {
            csprite.flipX = false;
            currentXPosition = transform.position.x;
        }



    }


}
