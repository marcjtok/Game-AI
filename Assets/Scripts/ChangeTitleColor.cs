using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTitleColor : MonoBehaviour
{
    public float timer = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2.0f)//change the float value here to change how long it takes to switch.
        {
            // pick a random color
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            // apply it on current object's material
           gameObject.GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            timer = 0;
        }
    }
}
