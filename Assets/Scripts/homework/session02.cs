﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class session02 : MonoBehaviour {

    public string[] marvel = { "IronMan", "CaptainAmerican", "WinterSoldier" };
    public List<int> mylist = new List<int>();

    int c, d;

    // Use this for initialization
    void Start()
    {

        int a = 2;
        int b = 3;

        if (a < 2 && b < 2)
        {
            Debug.Log("a&b<2");
        }
        else
            Debug.Log("a&b>=2");


        for (int c = 0; c < marvel.Length; c++)
        {
            Debug.Log("My favorite Marvel character " + c + " is " + marvel[c]);
        }

        // add every number that can be divided by 3 in 50-60

        for (int d = 50; d < 60; d++)
        {
            mylist.Add(d);

        }
        /*
        for (int d = 50; d < 60; d++)
        {
            if (d % 3 == 0)
            {
                Debug.Log("every number that can be divided by 3 in 50-60 is" + mylist[d]);
            }

        }
        */
        for (int d = 51; d < mylist.Count; d = d + 3)
        {
            Debug.Log("every number that can be divided by 3 in 50-60 is" + mylist[d]);
        }


    }

    // Update is called once per frame
    void Update () {
		
	}
}
