using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public enum Level
    {
        mainMenu,
        level1,
        level2,
        level3
    }

    [Header("Object Reference")]
    [SerializeField] private UIManager uiManager;

    private Level activeLevel;

    // Start is called before the first frame update
    void Start()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "MainMenu":
                uiManager.ChangeScreen(UIManager.UIScreen.mainMenu);
                activeLevel = Level.mainMenu;
                break;

            case "Level01":
                uiManager.ChangeScreen(UIManager.UIScreen.charCreate);
                activeLevel = Level.level1;
                break;

            case "Level02":
                uiManager.ChangeScreen(UIManager.UIScreen.gamePlay);
                activeLevel = Level.level2;
                break;

            case "Level03":
                uiManager.ChangeScreen(UIManager.UIScreen.shop);
                activeLevel = Level.level3;
                break;

            default:
                ChangeLevel(Level.mainMenu);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLevel(Level targetLevel)
    {
        switch (targetLevel)
        {
            case Level.mainMenu:
                SceneManager.LoadScene("MainMenu");
                uiManager.ChangeScreen(UIManager.UIScreen.mainMenu);
                activeLevel = Level.mainMenu;
                break;

            case Level.level1:
                SceneManager.LoadScene("Level01");
                uiManager.ChangeScreen(UIManager.UIScreen.charCreate);
                activeLevel = Level.level1;
                break;

            case Level.level2:
                SceneManager.LoadScene("Level02");
                uiManager.ChangeScreen(UIManager.UIScreen.gamePlay);
                activeLevel = Level.level2;
                break;

            case Level.level3:
                SceneManager.LoadScene("Level03");
                uiManager.ChangeScreen(UIManager.UIScreen.shop );
                activeLevel = Level.level3;
                break;
        }
    }

    public Level GetLevel()
    {
        return activeLevel;
    }
}
