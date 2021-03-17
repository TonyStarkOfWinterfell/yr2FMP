using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public GameObject childHold;
    public Transform fillHold;
    
    public void Start()
    {
        //Assigns the transform of the first child of the Game Object this script is attached to.
        fillHold = this.gameObject.transform.GetChild(0);

        //Assigns the first child of the first child of the Game Object this script is attached to.
        //grandChild = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;
    }

    public void SetMaxHealth()
    {
        //child scale x - 2.85
        //min = 0
        maxHealth = 100;
    }

    public void SetHealth()
    {
        
    }
}
