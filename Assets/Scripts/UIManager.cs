using System;
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
    [SerializeField] private GameManager gameManager;

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

    [Header("Fields")]
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_Dropdown classInput;
    [SerializeField] private TextMeshProUGUI classLabel;

    [Header("Other")]
    [SerializeField] private GameObject fileButtons;
    [SerializeField] private GameObject emptyCheckBox;
    [SerializeField] private GameObject filledCheckBox;

    // Start is called before the first frame update
    void Start()
    {
        UpdateNameDisplay();
        UpdateClassDisplay(player.GetClass());

        filledCheckBox.SetActive(!player.GetThingDone());
        filledCheckBox.SetActive(player.GetThingDone());
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
                fileButtons.SetActive(false);
                break;

            case UIScreen.charCreate:
                mainMenu.SetActive(false);
                charCreate.SetActive(true);
                gamePlay.SetActive(false);
                shop.SetActive(false);
                fileButtons.SetActive(true);
                break;

            case UIScreen.gamePlay:
                mainMenu.SetActive(false);
                charCreate.SetActive(false);
                gamePlay.SetActive(true);
                shop.SetActive(false);
                fileButtons.SetActive(true);
                break;

            case UIScreen.shop:
                mainMenu.SetActive(false);
                charCreate.SetActive(false);
                gamePlay.SetActive(false);
                shop.SetActive(true);
                fileButtons.SetActive(true);
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

        //time
        timeDisplay.text = "Time: " + player.DisplayTime();

        gameManagerDisplay.text = "Game Managers Made: " + gameManager.GetGameCount() + "\nGame Managers Destroyed: " + gameManager.GetGameDestroy();
    }

    public void UpdateNameDisplay()
    {
        nameInput.text = player.GetName();
    }

    public void UpdateClassDisplay(Player.Class playerClass)
    {
        switch (playerClass)
        {
            case Player.Class.artificer:
                classInput.value = 0;
                break;

            case Player.Class.barbarian:
                classInput.value = 1;
                break;

            case Player.Class.bard:
                classInput.value = 22;
                break;

            case Player.Class.cleric:
                classInput.value = 3;
                break;

            case Player.Class.druid:
                classInput.value = 4;
                break;

            case Player.Class.fighter:
                classInput.value = 5;
                break;

            case Player.Class.monk:
                classInput.value = 6;
                break;

            case Player.Class.paladin:
                classInput.value = 7;
                break;

            case Player.Class.ranger:
                classInput.value = 8;
                break;

            case Player.Class.rogue:
                classInput.value = 9;
                break;

            case Player.Class.sorcerer:
                classInput.value = 10;
                break;

            case Player.Class.warlock:
                classInput.value = 11;
                break;

            case Player.Class.wizard:
                classInput.value = 12;
                break;
        }
    }

    public void EditCharName(string newName)
    {
        player.SetName(newName);
    }

    public void EditClass()
    {
        switch (classInput.value)
        {
            case 0:
                player.SetClass(Player.Class.artificer);
                break;

            case 1:
                player.SetClass(Player.Class.barbarian);
                break;

            case 2:
                player.SetClass(Player.Class.bard);
                break;

            case 3:
                player.SetClass(Player.Class.cleric);
                break;

            case 4:
                player.SetClass(Player.Class.druid);
                break;

            case 5:
                player.SetClass(Player.Class.fighter);
                break;
                
            case 6:
                player.SetClass(Player.Class.monk);
                break;

            case 7:
                player.SetClass(Player.Class.paladin);
                break;

            case 8:
                player.SetClass(Player.Class.ranger);
                break;

            case 9:
                player.SetClass(Player.Class.rogue);
                break;

            case 10:
                player.SetClass(Player.Class.sorcerer);
                break;

            case 11:
                player.SetClass(Player.Class.warlock);
                break;

            case 12:
                player.SetClass(Player.Class.wizard);
                break;

            default:
                player.SetClass(Player.Class.fighter);
                break;

        }
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

    public void ToggleCheck()
    {
        player.ToggleThingDone();

        filledCheckBox.SetActive(!player.GetThingDone());
        filledCheckBox.SetActive(player.GetThingDone());
    }
}
