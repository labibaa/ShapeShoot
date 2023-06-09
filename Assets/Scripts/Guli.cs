using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Guli : MonoBehaviour
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
       
        transform.Translate(Vector2.right * Time.deltaTime * enemySpeed);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == transform.tag + "Enemy")
        {
            //increase score score++
            Shooter.score++;
            HighScore.SetHighScore();

            Destroy(collision.gameObject);
            Destroy(gameObject);

            Debug.Log("-------- Score-------" + Shooter.score);


        }
        else if (collision.tag == transform.tag || collision.tag=="Player")
        {
        }
        else
        {
            FindObjectOfType<AudioManager>().StopPlaying("Theme");
            FindObjectOfType<AudioManager>().Play("GameOver");
            SceneManager.LoadScene("GameOverScene");
            FindObjectOfType<AudioManager>().Play("GameOver");
        }





    }
  
}



// 3. Scoring system (show it in the console)
// 4. Adding the punishment (decrease score or game over when the wrong shape is projected)
