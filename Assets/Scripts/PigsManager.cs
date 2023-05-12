using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigsManager : MonoBehaviour
{
    GameManager gameManager;
    int pigsTotal;
    int pigsDestroyed = 0;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        pigsTotal = transform.childCount;
    }

    public void RegisterPigDestroy()
    {
        pigsDestroyed++;
  
        if(pigsDestroyed == pigsTotal)
        {
            if(gameManager != null)
            {
                gameManager.SwitchScene();
            }
        }
    }
}
