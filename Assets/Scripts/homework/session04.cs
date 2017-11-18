using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class session04 : MonoBehaviour {

    public GameObject columnPrefab;
    IEnumerator createColumnCoroutine;

    // Use this for initialization
    void Start () {

        createColumnCoroutine = DropColumns();


    }
	
	// Update is called once per frame
	void Update () {

        StartCoroutine(createColumnCoroutine);
        Debug.Log(Time.time);
        if (Time.time > 5)
        {
            StopCoroutine(createColumnCoroutine);
            StopAllCoroutines();



        }
}
