using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {
    public Score score;
    string[] colors = new string[6];

// Use this for initialization
void Start()
{
        colors[0] = "red";
        colors[1] = "blue";
        colors[2] = "green";
        colors[3] = "yellow";
        colors[4] = "cyan";
        colors[5] = "magenta";
}

// Update is called once per frame
void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == collision.gameObject.tag)
        {
        gameObject.tag = colors[Random.Range(0, colors.Length)];
            Destroy(collision.gameObject);
            score.AddScore();
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }

}
