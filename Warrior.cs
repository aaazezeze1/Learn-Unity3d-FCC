using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Player
{
    // Awake is the first function that is called
    //public void Awake()
    //{

    //}

    // Second function to be called
    //public void OnEnable()
    //{

    //}

    // Start is the third function to be called
    //public void Start()
    //{

    //}

    // inheritance
    // warrior class is inheriting the player class

    // constructor is needed to add values of health, power and name
    public Warrior(int health, int power, string name)
    {

        Health = health;
        Power = power;
        Name = name;

    }

    // Override the function
    public override void Attack()
    {
        Debug.Log("Warrior is attacking with AXE");
    }

}
