using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    Animator anim;
    int _isRunning = Animator.StringToHash("isRunning");
    public float speed;
    public int jumpPower = 1250;

    private bool facingRight = false;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        PlayerMove();
	}

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(9);

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        if(x < 0.0f && facingRight == false)
        {
            anim.SetTrigger(_isRunning);
            FlipPlayer();
        }
        if(x > 0.0f && facingRight == true)
        {
            anim.SetTrigger(_isRunning);
            FlipPlayer();
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        if((x * speed) == 0)
        {
            anim.ResetTrigger(_isRunning);
        }
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