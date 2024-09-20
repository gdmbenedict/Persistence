using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public enum UIScreen
    {
        mainMenu,
        charCreate,
        gamePlay,
        shop
    }

    [Header("Object Reference")]
    [SerializeField] private Player player;

    [Header("Modification Values")]
    [SerializeField] private int scoreIncrement = 100;
    [SerializeField] private int expIncrement = 100;
    [SerializeField] private int levelIncrement = 1;
    [SerializeField] private float healthIncrement = 10;
    [SerializeField] private int armorClassIncrement = 1;
    [SerializeField] private int statIncrement = 1;
    [SerializeField] private int goldIncrement = 10;

    [Header("Screens")]
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject charCreate;
    [SerializeField] private GameObject gamePlay;
    [SerializeField] private GameObject shop;

    [Header("Displays")]
    [SerializeField] private TextMeshProUGUI gameManagerDisplay;
    [SerializeField] private TextMeshProUGUI scoreDisplay;
    [SerializeField] private TextMeshProUGUI expDisplay;
    [SerializeField] private TextMeshProUGUI levelDisplay;
    [SerializeField] private TextMeshProUGUI healthDisplay;
    [SerializeField] private TextMeshProUGUI armorDisplay;
    [SerializeField] private TextMeshProUGUI STRDisplay;
    [SerializeField] private TextMeshProUGUI DEXDisplay;
    [SerializeField] private TextMeshProUGUI CONDisplay;
    [SerializeField] private TextMeshProUGUI ITLDisplay;
    [SerializeField] private TextMeshProUGUI WISDisplay;
    [SerializeField] private TextMeshProUGUI CHADisplay;
    [SerializeField] private TextMeshProUGUI timeDisplay;
    [SerializeField] private TextMeshProUGUI goldDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTextDisplays();
    }

    public void ChangeScreen(UIScreen uIScreen)
    {
        switch (uIScreen)
        {
            case UIScreen.mainMenu:
                mainMenu.SetActive(true);
                charCreate.SetActive(false);
                gamePlay.SetActive(false);
                shop.SetActive(false);
                break;

            case UIScreen.charCreate:
                mainMenu.SetActive(false);
                charCreate.SetActive(true);
                gamePlay.SetActive(false);
                shop.SetActive(false);
                break;

            case UIScreen.gamePlay:
                mainMenu.SetActive(false);
                charCreate.SetActive(false);
                gamePlay.SetActive(true);
                shop.SetActive(false);
                break;

            case UIScreen.shop:
                mainMenu.SetActive(false);
                charCreate.SetActive(false);
                gamePlay.SetActive(false);
                shop.SetActive(true);
                break;
        }
    }

    private void UpdateTextDisplays()
    {
        //score
        scoreDisplay.text = player.GetScore().ToString();

        //exp
        expDisplay.text = player.GetEXP().ToString();

        //level
        levelDisplay.text = player.GetLevel().ToString();

        //health
        healthDisplay.text = player.GetHealth().ToString();

        //armor
        armorDisplay.text = player.GetAC().ToString();

        //stats
        STRDisplay.text = player.GetSTR().ToString();
        DEXDisplay.text = player.GetDEX().ToString();
        CONDisplay.text = player.GetCON().ToString();
        ITLDisplay.text = player.GetITL().ToString();
        WISDisplay.text = player.GetWIS().ToString();
        CHADisplay.text = player.GetCHA().ToString();

        //gold
        goldDisplay.text = player.GetGold().ToString();
    }

    public void IncrementScore(bool incrementType)
    {
        if (incrementType)
        {
            player.ModScore(scoreIncrement);
        }
        else
        {
            player.ModScore(-scoreIncrement);
        }
    }

    public void IncrementEXP(bool incrementType)
    {
        if (incrementType)
        {
            player.ModEXP(expIncrement);
        }
        else
        {
            player.ModEXP(-expIncrement);
        }
    }

    public void IncrementLevel(bool incrementType)
    {
        if (incrementType)
        {
            player.ModLevel(levelIncrement);
        }
        else
        {
            player.ModLevel(-levelIncrement);
        }
    }

    public void IncrementHealth(bool incrementType)
    {
        if (incrementType)
        {
            player.ModHealth(healthIncrement);
        }
        else
        {
            player.ModHealth(-healthIncrement);
        }
    }

    public void IncrementAC(bool incrementType)
    {
        if (incrementType)
        {
            player.ModAC(armorClassIncrement);
        }
        else
        {
            player.ModAC(-armorClassIncrement);
        }
    }

    public void IncrementSTR(bool incrementType)
    {
        if (incrementType)
        {
            player.ModSTR(statIncrement);
        }
        else
        {
            player.ModSTR(-statIncrement);
        }
    }

    public void IncrementDEX(bool incrementType)
    {
        if (incrementType)
        {
            player.ModDEX(statIncrement);
        }
        else
        {
            player.ModDEX(-statIncrement);
        }
    }

    public void IncrementCON(bool incrementType)
    {
        if (incrementType)
        {
            player.ModCON(statIncrement);
        }
        else
        {
            player.ModCON(-statIncrement);
        }
    }

    public void IncrementITL(bool incrementType)
    {
        if (incrementType)
        {
            player.ModITL(statIncrement);
        }
        else
        {
            player.ModITL(-statIncrement);
        }
    }

    public void IncrementWIS(bool incrementType)
    {
        if (incrementType)
        {
            player.ModWIS(statIncrement);
        }
        else
        {
            player.ModWIS(-statIncrement);
        }
    }

    public void IncrementCHA(bool incrementType)
    {
        if (incrementType)
        {
            player.ModCHA(statIncrement);
        }
        else
        {
            player.ModCHA(-statIncrement);
        }
    }

    public void IncrementGold(bool incrementType)
    {
        if (incrementType)
        {
            player.ModGold(goldIncrement);
        }
        else
        {
            player.ModGold(-goldIncrement);
        }
    }
}
