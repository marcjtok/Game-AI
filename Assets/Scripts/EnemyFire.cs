using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {
    public GameObject spawn;
    public GameObject Shot;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Fire", 2.0f, 2f);
    }
	
	// Update is called once per frame
	void Update () {

    }
    void Fire()
    {
        GameObject myshot = Instantiate(Shot,spawn.transform.position, spawn.transform.rotation);
        myshot.gameObject.tag = gameObject.tag;
    }
}
