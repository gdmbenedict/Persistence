using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum Class
    {
        artificer,
        barbarian,
        bard,
        cleric,
        druid,
        fighter,
        monk,
        paladin,
        ranger,
        rogue,
        sorcerer,
        warlock,
        wizard
    }

    //stats
    private string name;
    private Class playerClass;
    private int score;
    private int exp;
    private int level;
    private int health;
    private int armorClass;
    private int str;
    private int dex;
    private int con;
    private int itl;
    private int wis;
    private int cha;
    private float time;
    private bool doneThing;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
