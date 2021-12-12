using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowParentTAg : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //to follow the parents tag
        gameObject.tag = transform.parent.tag;
	}
}
