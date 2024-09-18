using System;
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
    private float health;
    private int armorClass;
    private int str;
    private int dex;
    private int con;
    private int itl;
    private int wis;
    private int cha;
    private double time;
    private bool doneThing;


    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetClass(Class playerClass)
    {
        switch (playerClass)
        {
            case Class.artificer:
                this.playerClass = Class.artificer;
                break;

            case Class.barbarian:
                this.playerClass = Class.barbarian;
                break;

            case Class.bard:
                this.playerClass = Class.bard;
                break;

            case Class.cleric:
                this.playerClass = Class.cleric;
                break;

            case Class.druid:
                this.playerClass = Class.druid;
                break;

            case Class.fighter:
                this.playerClass = Class.fighter;
                break;

            case Class.monk:
                this.playerClass = Class.monk;
                break;

            case Class.paladin:
                this.playerClass = Class.paladin;
                break;

            case Class.ranger:
                this.playerClass = Class.ranger;
                break;

            case Class.rogue:
                this.playerClass = Class.rogue;
                break;

            case Class.sorcerer:
                this.playerClass = Class.sorcerer;
                break;

            case Class.warlock:
                this.playerClass = Class.warlock;
                break;

            case Class.wizard:
                this.playerClass = Class.wizard;
                break;
        }
    }

    public Class GetClass()
    {
        return playerClass;
    }

    public string DisplayClass()
    {
        switch (playerClass)
        {
            case Class.artificer:
                return "Artificer";

            case Class.barbarian:
                return "Barbarian";

            case Class.bard:
                return "Bard";

            case Class.cleric:
                return "Cleric";

            case Class.druid:
                return "Druid";

            case Class.fighter:
                return "Fighter";

            case Class.monk:
                return "Monk";

            case Class.paladin:
                return "Paladin";

            case Class.ranger:
                return "Ranger";

            case Class.rogue:
                return "Rogue";

            case Class.sorcerer:
                return "Sorcerer";

            case Class.warlock:
                return "Warlock";

            case Class.wizard:
                return "Wizard";

            default:
                return "???";
        }
    }

    public void ModScore(int scoreMod)
    {
        score += scoreMod;
    }

    public void SetScore(int score)
    {
        this.score = score;
    }

    public int GetScore() 
    { 
        return score; 
    }

    public void ModLevel(int modLevel)
    {
        level += modLevel;
    }

    public void SetLevel(int level)
    {
        this.level = level;
    }

    public int GetLevel()
    {
        return level;
    }

    public void ModHealth(float modHealth)
    {
        health += modHealth;
    }

    public void SetHealth(float health)
    {
        this.health = health;
    }

    public float GetHealth()
    {
        return health;
    }

    public void MedAC(int modAC)
    {
        armorClass += modAC;
    }

    public void SetAC(int armorClass)
    {
        this.armorClass = armorClass;
    }

    public int GetAC()
    {
        return armorClass;
    }

    public void ModSTR(int modSTR)
    {
        str += modSTR;
    }

    public void SetSTR(int str)
    {
        this.str = str;
    }

    public int GetSTR()
    {
        return str;
    }

    public void ModDEX(int modDex)
    {
        dex += modDex;
    }

    public void SetDEX(int dex)
    {
        this.dex = dex;
    }

    public int GetDEX()
    {
        return dex;
    }

    public void ModCON(int modCon)
    {
        con += modCon;
    }

    public void SetCON(int con)
    {
        this.con = con;
    }

    public int GetCON()
    {
        return con;
    }

    public void ModITL(int modItl)
    {
        itl += modItl;
    }

    public void SetITL(int itl)
    {
        this.itl = itl;
    }

    public int GetITL()
    {
        return itl;
    }

    public void ModWIS(int modWis)
    {
        wis += modWis;
    }

    public void SetWIS(int wis)
    {
        this.wis = wis;
    }

    public int GetWIS()
    {
        return wis;
    }

    public void ModCHA(int modCha)
    {
        cha += modCha;
    }

    public void SetCHA(int cha)
    {
        this.cha = cha;
    }

    public int GetCHA()
    {
        return cha;
    }

    public void SetTime(double time)
    {
        this.time = time;
    }

    public double GetTime()
    {
        return time;
    }

    public string DisplayTime()
    {
        return TimeSpan.FromSeconds(time).ToString();
    }

    public void SetThingDone(bool state)
    {
        doneThing = state;
    }

    public void ToggleThingDone()
    {
        doneThing = !doneThing;
    }

    public bool GetThingDone()
    {
        return doneThing;
    }
}
