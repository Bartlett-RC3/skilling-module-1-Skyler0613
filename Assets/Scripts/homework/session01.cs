using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class session01 : MonoBehaviour {

    //1.Variables
    //number
    public int myage = 23;
    public float myheight = 165.5f;
    //text
    public string str = "my name is Skyler";


    //2.Arrays
    public string[] study = { "ucl", "bartlett", "rc3" };
    public int[] myarray = new int[11];
    int a;


    //3.List
    public List<int> mylist = new List<int>();


    // Use this for initialization
    void Start () {
        //4.Fuction

        Debug.Log("my age is" + myage);
        Debug.Log(" result is: " + A(5, 3));



        for (a = 3; a < 10; a++)
        {
            myarray[a] = a + 100;
        }


        mylist.Add(1);
        mylist.AddRange(myarray);


       

    }

    // Update is called once per frame
    void Update()
   {
    }


        int A(int number1, int number2)
        {
            int b = number1 - number2;
            return b;
    }



}

