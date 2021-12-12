using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    //state machine
    public GameObject Shot;
    public GameObject spawn;
    public GameObject color1;
    public GameObject color2;
    string color1str;
    string color2str;
    enum GameState { blank, red, green, blue, yellow, magenta, cyan,}

    GameState currentState;
    // Use this for initialization
    void Start()
    {
        currentState = GameState.blank;
    }

    // Update is called once per frame
    void Update()
    {
        //changes game object tag to match the state;
        gameObject.tag = currentState.ToString();
        color1str = color1.gameObject.tag;
        color2str = color2.gameObject.tag;
        // Color Finite State Machine
        switch (currentState)
        {
            case GameState.blank:

                if (color1str == "blue" && color2str == "blue")
                {
                    currentState = GameState.blue;
                }
                if (color1str == "red" && color2str == "red")
                {
                    currentState = GameState.red;
                }
                if (color1str == "green" && color2str == "green")
                {
                    currentState = GameState.green;
                }
                if (color1str == "blue" && color2str == "red")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "red" && color2str == "blue")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "blue" && color2str == "green")
                {
                    currentState = GameState.cyan;
                }
                if (color1str == "green" && color2str == "blue")
                {
                    currentState = GameState.cyan;
                }
                if (color1str == "red" && color2str == "green")
                {
                    currentState = GameState.yellow;
                }
                if (color1str == "green" && color2str == "red")
                {
                    currentState = GameState.yellow;
                }
                break;
            case GameState.red:

                if (color1str == "blue" && color2str == "blue")
                {
                    currentState = GameState.blue;
                }
                if (color1str == "green" && color2str == "green")
                {
                    currentState = GameState.green;
                }
                if (color1str == "blue" && color2str == "red")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "red" && color2str == "blue")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "blue" && color2str == "green")
                {
                    currentState = GameState.cyan;
                }
                if (color1str == "green" && color2str == "blue")
                {
                    currentState = GameState.cyan;
                }
                if (color1str == "red" && color2str == "green")
                {
                    currentState = GameState.yellow;
                }
                if (color1str == "green" && color2str == "red")
                {
                    currentState = GameState.yellow;
                }
                break;
            case GameState.blue:
                if (color1str == "red" && color2str == "red")
                {
                    currentState = GameState.red;
                }
                if (color1str == "green" && color2str == "green")
                {
                    currentState = GameState.green;
                }
                if (color1str == "blue" && color2str == "red")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "red" && color2str == "blue")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "blue" && color2str == "green")
                {
                    currentState = GameState.cyan;
                }
                if (color1str == "green" && color2str == "blue")
                {
                    currentState = GameState.cyan;
                }
                if (color1str == "red" && color2str == "green")
                {
                    currentState = GameState.yellow;
                }
                if (color1str == "green" && color2str == "red")
                {
                    currentState = GameState.yellow;
                }
                break;
            case GameState.green:
                if (color1str == "blue" && color2str == "blue")
                {
                    currentState = GameState.blue;
                }
                if (color1str == "red" && color2str == "red")
                {
                    currentState = GameState.red;
                }
                if (color1str == "blue" && color2str == "red")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "red" && color2str == "blue")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "blue" && color2str == "green")
                {
                    currentState = GameState.cyan;
                }
                if (color1str == "green" && color2str == "blue")
                {
                    currentState = GameState.cyan;
                }
                if (color1str == "red" && color2str == "green")
                {
                    currentState = GameState.yellow;
                }
                if (color1str == "green" && color2str == "red")
                {
                    currentState = GameState.yellow;
                }
                break;
            case GameState.magenta:
                if (color1str == "blue" && color2str == "blue")
                {
                    currentState = GameState.blue;
                }
                if (color1str == "red" && color2str == "red")
                {
                    currentState = GameState.red;
                }
                if (color1str == "blue" && color2str == "green")
                {
                    currentState = GameState.cyan;
                }
                if (color1str == "green" && color2str == "blue")
                {
                    currentState = GameState.cyan;
                }
                if (color1str == "red" && color2str == "green")
                {
                    currentState = GameState.yellow;
                }
                if (color1str == "green" && color2str == "red")
                {
                    currentState = GameState.yellow;
                }
                break;
            case GameState.cyan:
                if (color1str == "blue" && color2str == "blue")
                {
                    currentState = GameState.blue;
                }
                if (color1str == "red" && color2str == "red")
                {
                    currentState = GameState.red;
                }
                if (color1str == "blue" && color2str == "red")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "red" && color2str == "blue")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "red" && color2str == "green")
                {
                    currentState = GameState.yellow;
                }
                if (color1str == "green" && color2str == "red")
                {
                    currentState = GameState.yellow;
                }
                break;
            case GameState.yellow:
                if (color1str == "blue" && color2str == "blue")
                {
                    currentState = GameState.blue;
                }
                if (color1str == "red" && color2str == "red")
                {
                    currentState = GameState.red;
                }
                if (color1str == "blue" && color2str == "red")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "red" && color2str == "blue")
                {
                    currentState = GameState.magenta;
                }
                if (color1str == "blue" && color2str == "green")
                {
                    currentState = GameState.cyan;
                }
                if (color1str == "green" && color2str == "blue")
                {
                    currentState = GameState.cyan;
                }
                break;
        }
        // to fire the bullets
        if(Input.GetKeyDown("space"))
        {
            Debug.Log("you have shot!");
            Fire();
        }
    }
    // function to fire bullets that match the player tag
    void Fire()
    {
        GameObject myshot = Instantiate(Shot, spawn.transform.position, spawn.transform.rotation);
        myshot.gameObject.tag = gameObject.tag;

    }
}
