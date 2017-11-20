using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using doggydoggy;

public class session02 : MonoBehaviour {

    public string[] marvel = { "IronMan", "CaptainAmerican", "WinterSoldier" };
    public List<int> mylist = new List<int>();
    Dictionary<string, string> music = new Dictionary<string, string>();

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
        foreach (string name in marvel)
        {
            Debug.Log(name);
        }

        music.Add("slot1", "classical");
        music.Add("slot2", "post rock");

        foreach (var item in music)
        {
            Debug.Log(item.Key + item);
        }


       /*or (int d = 51; d < 60; d = d + 3)
        {
            Debug.Log("every number that can be divided by 3 in 50-60 is" + mylist[d]);
        }*/
 

        Dog dogs = new Dog();

        Debug.Log("my first dog's name is "+dogs.dogname[0]);
        Debug.Log(int health);


    }

    // Update is called once per frame
    void Update () {

      

       



    }
}


