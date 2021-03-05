using UnityEngine;
using UnityEngine.UI;

public class ClickerTutorial : MonoBehaviour
{
    //E1
    public Text coinsText;
    public double coins;
    public double coinsClickValue;

    //E2
    public Text coinsPerSecText;
    public Text clickUpgrade1Text;
    public Text productionUpgrade1Text;

    public double coinsPerSecond;
    public double clickUpgrade1Cost;
    public int clickUpgrade1Level;

    public double productionUpgrade1Cost;
    public int productionUpgrade1Level;

    public void Start()
    {       
        clickUpgrade1Cost = 10;
        productionUpgrade1Cost = 25;
    }

    public void Update()
    {
        coinsPerSecond = productionUpgrade1Level;

        coinsText.text = "Coins: " + coins;
        coinsPerSecText.text = coinsPerSecond + " coins/s";
        clickUpgrade1Text.text = "Click Upgrade 1\nCost " + clickUpgrade1Cost + " coins\nPower: =! Click\nLevel: " + clickUpgrade1Level;
        productionUpgrade1Text.text = "Prouction Upgrade 1\nCost " + productionUpgrade1Cost + " coins\nPower: +1 coins/s\nLevel: " + productionUpgrade1Level;

        coins += coinsPerSecond * Time.deltaTime;
    }

    public void Click()
    {
        coins += coinsClickValue;
    }

    public void BuyClickUpgrade1()
    {
        if ( coins >= clickUpgrade1Cost)
        {
            clickUpgrade1Level++;
            coins -= clickUpgrade1Cost;
            clickUpgrade1Cost *= 1.07;
            coinsClickValue++;
        }        
    }

    public void BuyProductionUpgrade1()
    {
        if (coins >= productionUpgrade1Cost)
        {
            productionUpgrade1Level++;
            coins -= productionUpgrade1Cost;
            productionUpgrade1Cost *= 1.07;            
        }
    }


}
