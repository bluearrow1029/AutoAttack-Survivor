using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("# Game Object")]
    public PlayerController player;
    public PoolManager pool;
    public LevelUp uiLevelUp;

    [Header("# Game Control")]
    public bool isLive = true;
    public float gameTime;
    public float maxGameTime = 20f;

    [Header("# Player Info")]
    public int health;
    public int maxHealth = 100;
    public int level;
    public int kill;
    public int exp;
    public int[] nextExp = { 10, 20, 30, 50, 80, 120, 170, 230, 300, 380 }; 

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        health = maxHealth;

        // 임시
        uiLevelUp.Select(0);
    }

    private void Update()
    {
        gameTime += Time.deltaTime;

        if (gameTime > maxGameTime)
        {
            gameTime = maxGameTime;
        }
    }

    public void GetExp()
    {
        exp++;

        if (exp == nextExp[level])
        {
            level++;
            exp = 0;
            uiLevelUp.Show();
        }
    }

    public void Stop()
    {
        isLive = false;
        Time.timeScale = 0;
    }

    public void Resume()
    {
        isLive = true;
        Time.timeScale = 1;
    }
}