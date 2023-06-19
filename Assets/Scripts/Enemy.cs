using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log(Vector2.left);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * enemySpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Game Over");
            Destroy(collision.gameObject);
            //game over screen here
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
