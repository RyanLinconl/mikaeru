using UnityEngine;

public class Frog : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody2D rig;
    private Animator anim;

    public Transform rightCol;
    public Transform leftCol;
    public Transform headPoint;
    private bool colliding;

    [SerializeField]
    private LayerMask layer;

    private float jumpForce;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        rig.linearVelocity = new Vector2(speed, rig.linearVelocity.y);

        colliding = Physics2D.Linecast(rightCol.position, leftCol.position, layer);

        if(colliding)
        {
            transform.localScale = new Vector2(transform.localScale.x * -1f, transform.localScale.y);
            speed *= -1f;
        }
    }

    bool playerDestroyed;
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            float height = col.contacts[0].point.y - headPoint.position.y;

            if(height > 0 && !playerDestroyed)
            {
                rig.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10, ForceMode2D.Impulse);
                speed = 0;
                anim.SetTrigger("die");
                AudioManager.instance.PlaySound(AudioManager.instance.fxDeathEnemy);
                Destroy(gameObject, 0.33f);
            }else
            {
                playerDestroyed = true;
                AudioManager.instance.PlaySound(AudioManager.instance.fxDeathSpike);
                GameController.instance.ShowGameOver();
                Destroy(col.gameObject);
            }
        }
    }
}
