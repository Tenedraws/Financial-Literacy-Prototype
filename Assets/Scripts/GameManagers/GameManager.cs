using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f; 
        UIManager.Instance.Open(GameUIID.GameHud);
        UIManager.Instance.Open(GameUIID.OpeningScene);
    }
}
