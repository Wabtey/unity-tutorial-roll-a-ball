using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    private GameObject RootGems;

    public void Start()
    {
        RootGems = GameObject.Find("RootGems");
    }

    public void ResetGame()
    {
        foreach (Transform t in RootGems.transform)
        {
            t.gameObject.SetActive(true);
        }
    }
}
