
using UnityEngine;
using UnityEngine.Pool;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anmtr;
    public float direction;

    private float speed;
    public float walkingSpeed = 10f;
    public float runningSpeed = 20f;
    public float jumpHeight = 5f;
    private bool isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anmtr = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move left and right,
        direction = 0f;
        
        if (Input.GetKey(KeyCode.LeftShift)) {
            speed = runningSpeed;
        }
        else {
            speed = walkingSpeed;
        }

        if (Input.GetKey(KeyCode.A)) {
            direction = -1f;
        }
        
        if (Input.GetKey(KeyCode.D)) {
            direction = 1f;
        }

        rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocityY);

        //Jumping
        if (Input.GetKey(KeyCode.Space) && isGrounded) {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpHeight);
        }
        
        //animations
        anmtr.SetFloat("Speed", Mathf.Abs(rb.linearVelocityX));
        anmtr.SetBool("isGrounded", isGrounded);
    

        if (direction != 0) {
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Sign(direction) * Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
    }

    //isGrounded check
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground")) {
            isGrounded = true;

        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground")) {
            isGrounded = false;

        }
    }
}
