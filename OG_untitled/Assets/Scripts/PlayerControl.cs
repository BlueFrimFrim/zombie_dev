using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    public float speed;
    public int jumpPower = 1250;

    private bool facingRight = false;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        PlayerMove();
	}

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        if(x < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        if(x > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
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
}