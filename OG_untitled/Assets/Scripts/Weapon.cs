using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public float FireRate = 0f;
    public float WeaponDamage = 10f;
    public LayerMask NoHit;

    Transform FirePoint;
	// Use this for initialization
	void Start () {
        FirePoint = FirePoint.transform.Find("Firepoint");
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
        Vector3 FirePointPos = new Vector3(FirePoint.position.x, FirePoint.position.y, 0f);
        RaycastHit2D hit = Physics2D.Raycast(FirePointPos, FirePoint.position - FirePointPos);
        Debug.DrawRay(FirePointPos, FirePointPos, Color.cyan);
    }
}
