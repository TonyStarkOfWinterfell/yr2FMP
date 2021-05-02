using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScore : MonoBehaviour
{
    public Text currentScore;
    public Text highScore;
        
    public GameObject scoreHolder;
    public DontDestroy dontDestroy;

    void Start()
    {
        scoreHolder = GameObject.FindGameObjectWithTag("Cross");
        dontDestroy = scoreHolder.gameObject.GetComponent<DontDestroy>();

        currentScore.text = "£" + dontDestroy.currentMoney; 

        if (dontDestroy.currentMoney > dontDestroy.highMoney)
        {
            dontDestroy.highMoney = dontDestroy.currentMoney;
            highScore.text = "Current Best: £" + dontDestroy.highMoney;
        }
        else
        {
            highScore.text = "Current Best: £" + dontDestroy.highMoney;
        }

    }

}
