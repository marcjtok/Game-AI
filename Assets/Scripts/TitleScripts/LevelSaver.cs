using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSaver : MonoBehaviour {
    public string levelunlock;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // function to save level score to unlock next level;
    public void SaveLevel(int scoregained)
    {
        PlayerPrefs.SetInt(levelunlock, scoregained);
    }
}
