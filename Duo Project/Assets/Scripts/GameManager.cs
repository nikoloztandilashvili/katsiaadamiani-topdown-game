using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public static GameManager instance;
    public FloatingTextManager floatingTextManager;


    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager = FindObjectOfType<FloatingTextManager>();
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
