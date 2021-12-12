using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public GameObject GameOverMenu;
    public float health = 5;

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        if(health <= 0)
        {
            Time.timeScale = 0;
            OpenPanel();
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
    void OpenPanel()
    {
        GameOverMenu.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
