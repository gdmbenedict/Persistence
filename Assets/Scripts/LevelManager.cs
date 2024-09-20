using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
        
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
                uiManager.ChangeScreen(UIManager.UIScreen.mainMenu);
                break;

            case Level.level1:
                uiManager.ChangeScreen(UIManager.UIScreen.charCreate);
                break;

            case Level.level2:
                uiManager.ChangeScreen(UIManager.UIScreen.gamePlay);
                break;

            case Level.level3:
                uiManager.ChangeScreen(UIManager.UIScreen.shop );
                break;
        }
    }
}
