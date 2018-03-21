using UnityEngine;
using System.Collections;



public class PlayerControl : MonoBehaviour {

    //public float speed;
    public int jumpPower = 1250;

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
        FirePoint = transform.Find("Firepoint");
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
#if false
        if (Input.GetKey(KeyCode.S))
        {
            crouching = true;
        }
        else {
            crouching = false;
        }
        if (crouching == true) {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Crouch;
        } else {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Idle;
        }
#endif
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
        localScale.x *= (-1); // localScale.x = localScale.x * (-1);
        transform.localScale = localScale;
    }

    void Shoot()
    {
        Debug.Log("Test: Shooting");
        Vector2 FirePointPos = new Vector2(FirePoint.position.x, FirePoint.position.y);
        Vector2 Direction = new Vector2(gameObject.GetComponent<Rigidbody2D>().position.x + 100, 0f);
        RaycastHit2D hit = Physics2D.Raycast(FirePointPos, FirePoint.transform.right);
        Debug.DrawLine(FirePointPos, Direction, Color.white);
    }
}