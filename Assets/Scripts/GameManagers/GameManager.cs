using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        Time.timeScale = 0f;
        UIManager.Instance.Open(GameUIID.GameHud);
        UIManager.Instance.Open(GameUIID.OpeningScene);
    }
}
