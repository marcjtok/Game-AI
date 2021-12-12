using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour {
    public GameObject OpenPanels;
    public Object leveltoload;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    
	}

    public void OpenPanel()
    {
        OpenPanels.SetActive(true);
    }
    public void ClosePanel()
    {
        OpenPanels.SetActive(false);
    }
    public void OpenLevel()
    {
        SceneManager.LoadScene(leveltoload.name);
    }
}
