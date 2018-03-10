using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public float FireRate = 0f;
    public float WeaponDamage = 10f;
    public LayerMask NoHit;

    float TimeToFire = 0f;
    Transform FirePoint;
	// Use this for initialization
	void Start () {
        Transform transform1 = transform.Find("Firepoint");
        FirePoint = transform1;
        if(FirePoint == null) {
            Debug.LogError("FirePoint: NULL");
        }


	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
	}

    void Shoot()
    {
        Debug.Log("Test: Shooting");
        Vector2 FirePointPos = new Vector2(FirePoint.position.x, FirePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(FirePointPos);
    }
}
