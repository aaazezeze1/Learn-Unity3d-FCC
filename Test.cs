using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Test : MonoBehaviour
{
    //Printing in the Console
    //print("This is form PRINT");
    //Debug.Log("This is from DEBUG.LOG");

    // Data Types
    //float speed = 1.4f;
    //double mana = 15.5;
    //int health = 100;
    //string playerName = "Warrior";
    //bool isDead = false;
    //char oneChar = 'a';

    // classes
    Player warrior;
    Player archer;

    private void Start()
    {
        // Operations with Variables
        //int a = 10;
        //int b = 5;
        //int c = a + b;

        //string name = "Ruce";
        //string lastName = " Duvall";
        //string fullName = name + lastName;

        //Debug.Log("A + B = " + c);
        //Debug.Log(a + " + " + b + " = " + c);
        //Debug.Log(fullName);

        //CalculateTwoNumbers();
        //CalculateTwoNumbers(30, 22);

        //float sum = ReturnTwoNumbers();
        //Debug.Log("The sum is " + ReturnTwoNumbers());

        //Debug.Log("The sum is: " + ReturnTwoNumbers(10, 20));

        // Conditional Statements
        //float health = 100;
        //if (health == 0)
        //{
        //    if ()
        //    {

        //    }
        //} else if (health < 50) 
        //{

        //} else
        //{

        //}

        // || is or
        // && is and
        //if (health < 20 || health < 30)
        //{

        //}

        //if (health == 0)
        //{
        //    Debug.Log("Health is 0 Player has died");
        //} else if (health <= 50) {
        //    Debug.Log("Health is less than 50 player has unlocked some power");
        //} else
        //{
        //    Debug.Log("Player has health greater than 50");
        //}

        //Switch Statements
        //switch(health)
        //{
        //    case 100:
        //        Debug.Log("Health is 100");
        //        break;
        //    case 50:
        //        Debug.Log("Health is 50");
        //        break;
        //    case 0:
        //        Debug.Log("Health is 0");
        //        break;

        //    default:
        //        Debug.Log("Health is neither of the values above");
        //        break;
        //}

        // Loops

        //For Loop
        //for (int i = 0; i < 10; i++)
        //{
        //    Debug.Log("The value of i: " + i);
        //}

        // While Loop
        //int i = 0;

        //while (i < 10) 
        //{
        //    Debug.Log("The value of i: " + i);
        //    i++;
        //}

        // Call the coroutine function
        //StartCoroutine(ExecuteSomething());

        //StartCoroutine("ExecuteSomething");
        //StopCoroutine("ExecuteSomething");

        // class
        // create a new object from a class
        //Player warrior = new Player();

        // call constructor with parameters
        // you can create multiple players
        //Player warrior = new Player(1, 2, "Lizard");
        //Player archer = new Player(20, 30, "Archer");

        //warrior = new Player(1, 2, "Lizard");
        //archer = new Player(20, 30, "Archer");

        // set and get
        // using functions to access variables
        //warrior.SetHealth(20);
        //Debug.Log("The health of the warrior is: " + warrior.GetHealth());

        // get and set
        //warrior.Health = 50;
        //Debug.Log("The health is: " + warrior.Health);

        // inheritance
        // the values inside new warrior doesn't show because of inheritance
        Warrior w = new Warrior(3, 5, "Warrior");
        // add the value of health
        warrior.Health = 20;
        // w is also the same as Warrior
        w.Info();

        //warrior.Info();
        //archer.Info();

        //warrior.Attack();

        // Accessibility Modifiers or Data Encapsulation
        // public and private
        // variables are private by default
    }

    // Functions

    // a function that doesn't return anything
    //void CalculateTwoNumbers()
    //{
    //    int a = 10;
    //    int b = 5;
    //    int c = a + b;

    //    Debug.Log("The sum of a and b is: " + c);
    //}

    // a function that takes parameters
    //void CalculateTwoNumbers(float a, float b)
    //{
    //    Debug.Log("The sum of a and b is: " + (a + b));
    //}

    // function that returns a value
    //float ReturnTwoNumbers()
    //{
    //    return 20 + 30;
    //}

    //float ReturnTwoNumbers(float a, float b)
    //{
    //    return a + b;
    //}

    // Coroutines
    // delay in game like boss appears in 5 secs instead of right away

    //IEnumerator ExecuteSomething()
    //{
    //    // wait for 2 seconds
    //    yield return new WaitForSeconds(2f);

    //    Debug.Log("Something is executed");
    //    yield return new WaitForSeconds(2f);
    //}
}
