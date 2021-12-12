using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //checks the game object tag and changes the colour according to the tags
		if(gameObject.tag == "red")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0.5f);

        }
        if (gameObject.tag == "blue")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1, 0.5f);
        }
        if (gameObject.tag == "green")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 0.5f);
        }
        if (gameObject.tag == "cyan")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 1, 1, 0.5f);


        }
        if (gameObject.tag == "yellow")
        {
          gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 0.16f, .7f);

        }
        if (gameObject.tag == "magenta")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0, 1, 0.5f);

        }
    }
}
