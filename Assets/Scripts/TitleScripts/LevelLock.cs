using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLock : MonoBehaviour {
    public string levelunlock;
    //This field should be set by the inspector
    [SerializeField]
    //level requirement
    int levelRequirement;
    // checks whether the playerpref has the selected level requirements been met;
    public void Start()
    {
        int currentLevel = PlayerPrefs.GetInt(levelunlock);
        bool levelUnlocked = currentLevel >= levelRequirement;
        GetComponent<Button>().interactable = levelUnlocked;
    }
}
