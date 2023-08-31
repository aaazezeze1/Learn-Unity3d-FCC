using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Player
{
    // Classes

    //int health = 100;
    //int power = 50;
    //string name = "Warrior";

    // this keyword refers to these below
    //int health;
    //int power;
    //string name;

    //private int health;

    private int _health;

    // get and set
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            // the value is equal to 20
            _health = value;
        }
    }

    private int power;
    private string name;

    // inheritance
    // this is needed 
    public Player()
    {

    }

    // Constructor
    public Player(int health, int power, string name)
    {
        // this refers to class name
        //this._health = health;
        Health = health;
        this.power = power;
        this.name = name;

        //Debug.Log("Health is: " + health);
        //Debug.Log("Power is: " + power);
        //Debug.Log("Name is: " + name);
    }

    public void Attack()
    {
        Debug.Log(name + " is attacking");
    }

    public void Info()
    {
        //Debug.Log("Health is: " + _health);
        Debug.Log("Health is: " +Health);
        Debug.Log("Power is: " + power);
        Debug.Log("Name is: " + name);
    }

    // setters and getters can give you access when variables are private
    // using functions to access variables
    //public void SetHealth(int health)
    //{
    //    this.health = health;
    //}

    //public int GetHealth()
    //{
    //    return health;
    //}


}
