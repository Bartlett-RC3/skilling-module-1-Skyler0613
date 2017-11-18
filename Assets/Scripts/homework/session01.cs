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

    //5.Dictionary
    Dictionary<string, string> music = new Dictionary<string, string>();



    // Use this for initialization
    void Start () {
        //4.Fuction

        Debug.Log(str);
        Debug.Log("my age is " + myage);
        Debug.Log("my height is " + myheight);
        Debug.Log(" result is: " + A(5, 3));



        for (a = 3; a < 11; a++)
        {
            myarray[a] = a + 100;
        }



        mylist.AddRange(myarray);

        Debug.Log("the last number is " + mylist[mylist.Count - 1]);
        Debug.Log(mylist.ToArray().Length);

        music.Add("slot1", "classical");
        music.Add("slot2", "post rock");
        Debug.Log(" my favorite music is : " + music["slot1"]+" and "+ music["slot2"]);
        Debug.Log(" slot 1 and slot 2 is " + music.ContainsKey("slot1"));

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

