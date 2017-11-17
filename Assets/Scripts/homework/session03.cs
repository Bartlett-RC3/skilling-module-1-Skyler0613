using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class session03 : MonoBehaviour
{

    int a = 0;
    public GameObject CubeRefe;
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

        }
    }


