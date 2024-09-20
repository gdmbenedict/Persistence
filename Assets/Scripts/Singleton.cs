using UnityEngine;

public class Singleton : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public static Singleton instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)
        {
            instance.GetComponent<GameManager>().ModGameCount(1);
        }
        else
        {
            gameManager.ModGameCount(1);
        }
        

        if (instance != null && instance!= this && instance.GetComponent<GameManager>().keepManager)
        {
            instance.GetComponent<GameManager>().ModGameDestroy(1);
            Destroy(gameObject);
        }
        else if (instance != null && instance != this && !instance.GetComponent<GameManager>().keepManager)
        {
            //transfering debug info
            gameManager.SetGameCount(instance.GetComponent<GameManager>().GetGameCount());
            gameManager.SetGameDestroy(instance.GetComponent<GameManager>().GetGameDestroy());

            //destroy previous game manager
            gameManager.ModGameDestroy(1);
            Destroy(instance);

            //set new game manager as instance
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
    }
}
