using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //makes sure the barrier tag is equal to the players tag
        gameObject.tag = transform.parent.tag;
	}
    //checks whether the barrier tag is the same as the enemy bullet tag if so destroy the bullet;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == collision.gameObject.tag)
        {
            Destroy(collision.gameObject);
        }
    }
}
