using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Object Reference")]
    [SerializeField] Player player;
    [SerializeField] LevelManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        }
    }
}

[Serializable]
class SaveData
{

}
