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

    //private int power;

    private int _power;

    public int Power
    {
        get
        {
            return _power;
        }
        set
        {
            // the value is equal to 20
            _power = value;
        }
    }

    private string _name;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            // the value is equal to 20
            _name = value;
        }
    }

    // inheritance
    // this is needed 

    // empty constructor for warrior.cs
    public Player()
    {

    }

    // Constructor
    public Player(int health, int power, string name)
    {
        // this refers to class name
        //this._health = health;
        Health = health;
        Power = power;
        Name = name;

        //Debug.Log("Health is: " + health);
        //Debug.Log("Power is: " + power);
        //Debug.Log("Name is: " + name);
    }

    // Override the function
    // you won't see this code but the one in warrior file will
    public virtual void Attack()
    {
        Debug.Log("Player is attacking with fire");
    }

    public void Info()
    {
        //Debug.Log("Health is: " + _health);
        Debug.Log("Health is: " + Health);
        Debug.Log("Power is: " + Power);
        Debug.Log("Name is: " + Name);
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
