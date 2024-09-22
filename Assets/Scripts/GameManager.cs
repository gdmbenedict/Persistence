using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Object Reference")]
    [SerializeField] private Player player;
    [SerializeField] private LevelManager levelManager;
    [SerializeField] private UIManager uiManager;

    private int gameManCount = 0;
    private int gameManDestroy = 0;

    public bool keepManager = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputChangeScene();
    }

    private void InputChangeScene()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            levelManager.ChangeLevel(LevelManager.Level.mainMenu);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            levelManager.ChangeLevel(LevelManager.Level.level1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            levelManager.ChangeLevel(LevelManager.Level.level2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            levelManager.ChangeLevel(LevelManager.Level.level3);
        }
    }

    public void NewGame()
    {
        keepManager = false;
        levelManager.ChangeLevel(LevelManager.Level.level1);
    }

    public void SetGameCount(int count)
    {
        gameManCount = count;
    }

    public void ModGameCount(int count)
    {
        gameManCount += count;
    }

    public int GetGameCount()
    {
        return gameManCount;
    }

    public void SetGameDestroy(int destroy)
    {
        gameManDestroy = destroy;
    }

    public void ModGameDestroy(int destroy)
    {
        gameManDestroy += destroy;
    }
    
    public int GetGameDestroy()
    {
        return gameManDestroy;
    }

    /// <summary>
    /// Method that saves game data to a file
    /// </summary>
    public void Save()
    {
        //Getting file path
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        //Writting data to serializable class
        SaveData data = new SaveData();
        data.playerName = player.GetName();
        data.playerClass = player.GetClass();
        data.playerScore = player.GetScore();
        data.playerExp = player.GetEXP();
        data.playerLevel = player.GetLevel();
        data.playerHealth = player.GetHealth();
        data.playerAC = player.GetAC();
        data.playerSTR = player.GetSTR();
        data.playerDEX = player.GetDEX();
        data.playerCON = player.GetCON();
        data.playerITL = player.GetITL();
        data.playerWIS = player.GetWIS();
        data.playerCHA = player.GetCHA();
        data.playerGold = player.GetGold();
        data.doneThing = player.GetThingDone();
        data.activeLevel = levelManager.GetLevel();
        data.timePlayed = player.GetTime();

        //Serializing Data & saving to file
        bf.Serialize(file, data);
        file.Close();
    }

    /// <summary>
    /// Method that loads game data from a file
    /// </summary>
    public void Load()
    {
        //check for file existance
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            //opening save file
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            
            //loading data
            SaveData data = (SaveData)bf.Deserialize(file);
            file.Close();

            //reading values from data
            player.SetName(data.playerName);
            player.SetClass(data.playerClass);
            player.SetScore(data.playerScore);
            player.SetEXP(data.playerExp);
            player.SetLevel(data.playerLevel);
            player.SetHealth(data.playerHealth);
            player.SetAC(data.playerAC);
            player.SetSTR(data.playerSTR);
            player.SetDEX(data.playerDEX);
            player.SetCON(data.playerCON);
            player.SetITL(data.playerITL);
            player.SetWIS(data.playerWIS);
            player.SetCHA(data.playerCHA);
            player.SetGold(data.playerGold);
            player.SetThingDone(data.doneThing);
            player.SetTime(data.timePlayed);

            //update some values
            uiManager.SetUI();

            //load saved level
            levelManager.ChangeLevel(data.activeLevel);
        }
    }
}

[Serializable]
class SaveData
{
    //player data
    public string playerName;
    public Player.Class playerClass;
    public int playerScore;
    public int playerExp;
    public int playerLevel;
    public float playerHealth;
    public int playerAC;
    public int playerSTR;
    public int playerDEX;
    public int playerCON;
    public int playerITL;
    public int playerWIS;
    public int playerCHA;
    public int playerGold;
    public bool doneThing;
    public double timePlayed;

    //level
    public LevelManager.Level activeLevel;
}
