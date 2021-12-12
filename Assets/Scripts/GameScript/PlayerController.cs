using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public GameObject GameOverMenu;
    public float health = 5;
    public LevelSaver levelsave;
    public Score score;

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        // when health is 0 stop time and save score and open the game over panel
        if(health <= 0)
        {
            Time.timeScale = 0;
            OpenPanel();
            levelsave.SaveLevel(score.score);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!(collision.gameObject.tag == gameObject.tag))
        {
            Destroy(collision.gameObject);
            health--;
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
    //to open the game over panel
    void OpenPanel()
    {
        GameOverMenu.SetActive(true);
    }
    // to restart the level
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
