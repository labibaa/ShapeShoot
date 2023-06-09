using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{
    public static bool high=false;

    public static void SetHighScore() {

        if (Shooter.score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", Shooter.score);
            high = true;
            
        }
        
    }

    
}
