using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelect : MonoBehaviour {
    public GameObject color1;
    public GameObject color2;
    private GameObject currentColor;
    public bool swap;
	// Use this for initialization
	void Start () {
        swap = false;
	}
	
	// Update is called once per frame
	void Update () {
        //buttons to switch to the tags of the colour selectors;
		if(Input.GetButton("Switch Red"))
        {
            currentColor.gameObject.tag = "red";
        }
        if (Input.GetButton("Switch Blue"))
        {
            currentColor.gameObject.tag = "blue";
        }
        if (Input.GetButton("Switch Green"))
        {
            currentColor.gameObject.tag = "green";
        }

        if (swap == true)
        {
            currentColor = color2;
        }
        if (swap == false)
        {
            currentColor = color1;
        }
        if(Input.GetKeyDown("y"))
        {

            if (swap == true)
            {
                swap = false;
            }
            else if (swap == false)
            {
                swap = true;
            }
        }

    }
}
