using UnityEngine;

public class player : MonoBehaviour
{

    public float Speed;
    public float JumpForce;
    public bool isJumping;
    public bool doubleJump;
    private Rigidbody2D rig;
    private Animator anim;

    bool isBlowing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //Move o personagem em uma posição forçadamente
        //transform.position += movement * Time.deltaTime * Speed;

        float movement = Input.GetAxis("Horizontal");

        rig.linearVelocity = new Vector2(movement * Speed, rig.linearVelocity.y);

        if (movement > 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (movement < 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        if (movement == 0f)
        {
            anim.SetBool("walk", false);
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && !isBlowing)
        {
            if (!isJumping)
            {
                rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
                doubleJump = true;
                anim.SetBool("jump", true);
                AudioManager.instance.PlaySound(AudioManager.instance.fxJump);
            }
            else if (doubleJump)
            { 
                rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
                doubleJump = false;
                AudioManager.instance.PlaySound(AudioManager.instance.fxJump);
            }
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = false;
            anim.SetBool("jump", false);
        }

        if (collision.gameObject.tag == "Spike")
        {
            AudioManager.instance.PlaySound(AudioManager.instance.fxDeathSpike);
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "saw")
        {
            AudioManager.instance.PlaySound(AudioManager.instance.fxDeathSpike);
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = true;
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 11)
        {
            isBlowing = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 11)
        {
            isBlowing = false;
        }
    }
}
