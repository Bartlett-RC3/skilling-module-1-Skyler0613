using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class session03 : MonoBehaviour {

    int a = 0;
    public GameObject CubeRefe;
    bool moveleft = true;
    bool moveright = false;

    // Use this for initialization
    void Start() {
     if (moveleft == true)
        {
            if (a <= 17)
            {
                gameObject.transform.Translate(Vector3.left);
                a++;
            }
            else
            {
                moveleft = false;
                moveright = true;
                a = 0;
            }
        }
     if (moveright == true )
        {
            if (a <= 17)
            {
                gameObject.transform.Translate(Vector3.right);
                a++;
            }
            else
            { 
            moveleft = true;
                moveright = false;
                a = 0; }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
