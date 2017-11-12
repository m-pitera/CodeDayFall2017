using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VICTORY : MonoBehaviour {
    public GameObject theVictory;

    private void OnTriggerEnter2D(Collider2D other)
    {

        //Debug.Log("xd");
        Instantiate(theVictory);
    }
}