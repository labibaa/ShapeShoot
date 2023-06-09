using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    List<GameObject> enemies = new List<GameObject>();

    public float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        
        Spawn();
    }
    private void Spawn()
    {
        int temp = Random.Range(0, enemies.Count);
        Instantiate(enemies[temp], transform.position, Quaternion.identity);
        Invoke(methodName: "Spawn", spawnTime);
    }
}