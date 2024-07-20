using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }
    private int highScore = 0;
    private int currentScore = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Reload()
    {
        highScore = Math.Max(highScore, currentScore);
        currentScore = 0;
        SceneManager.LoadScene("Title");
    }

    public void AddToScore(int addition)
    {
        currentScore += addition;
    }
}
