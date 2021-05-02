using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{    
    /*public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }*/


    public void StartGame()
    {
        SceneManager.LoadScene("Game");        
    }

    public void QuitGame()
    {
        Debug.Log("quit");        
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");        
    }

    /*

    SceneManager.LoadScene("HighScore");

    */
}