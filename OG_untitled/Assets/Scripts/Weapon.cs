using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public float FireRate = 0f;
    public float WeaponDamage = 10f;
    public LayerMask NoHit;

    Transform FirePoint;
    // Use this for initialization
    void Awake() {
        FirePoint = transform.Find("Firepoint");
       if (FirePoint == null) {
            Debug.LogError("FirePoint: NULL");
       }
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }


    void Shoot()
    {
        Debug.Log("Test: Shooting");
        Vector2 FirePointPos = new Vector2(FirePoint.position.x, FirePoint.position.y);
        Vector2 Direction = new Vector2(gameObject.GetComponent<Rigidbody2D>().position.x - 100, 0f);
        RaycastHit2D hit = Physics2D.Raycast(FirePointPos, FirePoint.transform.right);
        Debug.DrawLine(FirePointPos, Direction, Color.white);
    }
}
