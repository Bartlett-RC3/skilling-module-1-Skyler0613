// Refrences
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session_1 : MonoBehaviour {


    // 1.Varibles
    // Scope -- type -- Name -- Value

    // numbers
    public int myFirstIntegerNumber = 98; //make sure you end with ;
    float myFirstFloatNumber = 1.7f;

    // text
    public string myFirstString = "My Text is here.";

    //Logical viriable
    bool myFirstBoolean = false;

    // Data stuctures
    // Scope -- Type -- Values


    //3.a.Arrays
    public int[] myintegrerArray = { 1, 2, 3, 4, 5 };
    public float[] myFloatArray = new float[5];

    //3.b.Lists
    public List<int> myIntegeList = new List<int>();


    //2.Fuctions
    //Scope -- Type -- Varibles -- Body (Instructions)

    //4.Dictionary
    Dictionary<string, string> weapons = new Dictionary<string, string>();






    // Use this for initialization
    void Start () {
        Debug.Log("Addition of 5 and 3 is:" + AdditionOfNumbers(5, 3));
        myFloatArray[2] = 3.2f;
        myFloatArray[3] = 5.6f;
        myFloatArray[4] = 9.2f;

        myIntegeList.Add(1);
        myIntegeList.Add(2);
        myIntegeList.Add(3);

        myIntegeList.Remove(0);

        weapons.Add("slot1", "sword");
        print("weapon in slot 1" + weapons ["slot1"]);
        print("slot 2 equiped" + weapons.ContainsKey("slot 2"));


    }
	

	// Update is called once per frame
	void Update () {
        //Debug.Log("Hello world!");
        
    }

    int AdditionOfNumbers(int number1, int number2)
    {
        int additionResult = number1 + number2;
        return additionResult;
    }
}
