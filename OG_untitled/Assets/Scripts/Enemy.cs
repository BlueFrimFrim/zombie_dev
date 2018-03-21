using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private int Health = 2;
    private int Lock = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy" && Lock == 0) {
            Damage();
        }
    }

    // Update is called once per frame
    void Update () {
		if(Health <= 0) {
            Destroy(gameObject);
        }
	}

    private void Damage()
    {
        --Health;
    }
}
