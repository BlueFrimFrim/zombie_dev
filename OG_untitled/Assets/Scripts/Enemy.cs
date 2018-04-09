using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private int Health = 2;
    private int Lock = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy") {
            Debug.Log("HIT");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void Damage()
    {
    }
}
