using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shooter : MonoBehaviour
{
    public GameObject[] guli;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void Shoot(int guliNo)
    {
        Instantiate(guli[guliNo], transform.position, Quaternion.identity);

    }

    
}
