using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DController : MonoBehaviour
{

    public Animator animator;

    public float MovementSpeed = 1;
    public float JumpForce = 1;
    private Rigidbody2D _rigidbody;

    private bool facingRight;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        facingRight = true;
        animator.SetBool("IsGrounded", true);
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");

        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        Flip(movement);

        SetAnimatorStates(movement);

        CheckIfGrounded();

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            animator.SetBool("IsGrounded", false);
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }

    // Sets animator variables through scrip for UpwardsVelocity and MovementSpeed
    private void SetAnimatorStates(System.Single movement)
    {
        animator.SetFloat("MovementSpeed", Mathf.Abs(movement));

        animator.SetFloat("UpwardsVelocity", _rigidbody.velocity.y);
    }

    // Checks if the player character is grounded and sets animator bool
    private void CheckIfGrounded()
    {
        if (_rigidbody.velocity.y == 0)
        {
            animator.SetBool("IsGrounded", true);
        }
    }

    // Face player character the same way the movement velocity is positive
    private void Flip(float moveHorizontal)
    {
        if (moveHorizontal > 0 && !facingRight || moveHorizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }

}