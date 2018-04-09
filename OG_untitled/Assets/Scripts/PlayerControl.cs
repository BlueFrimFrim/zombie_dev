using UnityEngine;
using System.Collections;



public class PlayerControl : MonoBehaviour {

    public int jumpPower = 2000;
    public Sprite Testing;
    private bool facingRight = false;
    public LayerMask NoHit;
    Transform FirePoint;

    #region Vars
    public Vector2 Speed;
    #endregion
    // Use this for initialization
    void Start ()
    {
        FirePoint = transform.Find("FirePoint");
        if (FirePoint == null) {
            Debug.LogError("FirePoint: NULL");
        }
    }
	
	// Update is called once per frame
	void Update () {
        PlayerMove();
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
	}

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        if (x < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        if(x > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = Speed * x;// new Vector2(x * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= (-1); 
        transform.localScale = localScale;
    }

    // This may not work if x is negative...
    void Shoot()
    {
        int dir = 1; // Direction for raycast.
        if(facingRight == false) { dir = 1; }
        else if(facingRight == true) { dir = -1; }
        Vector2 FirePointPos = new Vector2(FirePoint.position.x, FirePoint.position.y);
        Vector2 Direction = new Vector2(gameObject.GetComponent<Rigidbody2D>().position.x + 100, 0f);
        RaycastHit2D hit = Physics2D.Raycast(FirePointPos, Direction * dir);
        Debug.DrawRay(FirePointPos, Direction * dir, Color.white);
        Debug.Log(Direction);
        if(hit.collider.tag == "Enemy") { Debug.Log("RayCast Hit"); }
    }
}