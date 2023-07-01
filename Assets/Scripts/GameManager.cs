using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            Init();
            DontDestroyOnLoad(gameObject);
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private string hightScoreKey = "HigtScore";

    public int HightScore
    {
        get
        {
            return PlayerPrefs.GetInt(hightScoreKey, 0);
        }
        set
        {
            PlayerPrefs.SetInt(hightScoreKey, value);
        }
    }

    private int _currentScore;

    public int CurrentScore
    { get; set; }
    
    public bool IsInitialized
    { get; set; }

    private void Init()
    {
        CurrentScore = 0;
        IsInitialized = false;
    }

    private const string MainMenu = "MainMenu";
    private const string Gameplay = "Gameplay";

    public void GoToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(MainMenu);
    }

    public void GoToGameplay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Gameplay);
    }


}
