using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4 : MonoBehaviour
{

    public GameObject columnPrefab;
}
   // IEnumerator

	/*/ Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator DropColumns()
    {
        yield return new WaitForSeconds(5);
        Vector3 columnPosition = new Vector3 (Random.Range(-5f, 3f), Random.Range(8f, 1f), Random.Range(-7f, 1f));
        Quaternion columnRotation = new Quaternion
        //GameObject newColumn = Instantiate()
    }*/


