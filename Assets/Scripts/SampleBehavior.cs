using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//After a class name there is a ":" which means this class is inherited. 
//Think of it as being a type of something else.
//This class "SampleBehaviour" is a type of "MonoBehaviour"
//MonoBehaviour is a Class as well it is just built into Unity for us to use.
//They can be attatched to objects in the game.
public class SampleBehavior : MonoBehaviour
{
    private int numA;
    private int numB;
    private float numC;
    private string text;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log is how you can print things in the Unity console.
        Debug.Log("The game has started!");
        numA = 1;
        numB = 2;
        numC = 1.5f;
        int numD = numA + numB;

        text = "A + B = " + numD;
        //TODO: Why does this print the wrong answer? Make it print the correct answer.
        Debug.Log(text);
        //TODO: I want to do the same with numbers A and C.
        // text = "A + C = " + numA + numC;
        // Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
