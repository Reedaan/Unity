using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //create a variable to store your name
    public string myName = "Simon";
    //create a variable to store your age
    public int myAge = 24;
    //create a variable to store your speed
    public float mySpeed = 0f;
    //create a health variable
    public int playerHealth = 100;
    //create a speed variable
    public float speed = 0f;
    //variable to check if all keys were collected
    public bool keysColleted = false;
    //variable for ammo count
    public int ammo = 10;
    void Start()
    {
        Debug.Log(myName);
        Debug.Log(myAge);
        Debug.Log(mySpeed);
        Debug.Log(playerHealth);
        Debug.Log(speed);
        Debug.Log(keysColleted);
        Debug.Log(ammo);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
