using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class session03 : MonoBehaviour
{

    int a = 0;
    public GameObject Cube1;
    bool moveleft = true;
    bool moveright = false;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (moveleft == true)
        {
            if (a <= 10)
            {
                gameObject.transform.Translate(Vector3.left);
                a++;
            }
            else
            {
                moveleft = false;
                moveright = true;
                a = -10;
            }
        }
        
            if (moveright == true)
            {
                if (a <= 10)
                {
                    gameObject.transform.Translate(Vector3.right);
                    a++;
                }
                else
                {
                    moveleft = true;
                    moveright = false;
                    a = -10;
                }
            }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(new Vector3(0, 5, 10));
        }


        if (Input.GetMouseButtonDown(0))
        {

            Renderer rend = GetComponent<Renderer>(); 
            rend.material.SetColor("_Color", Color.blue);
            
        }
        




    }
}


