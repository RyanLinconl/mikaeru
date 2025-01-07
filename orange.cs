using UnityEngine;

public class orange : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject collected;
    public int Score;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);
            GameController.instance.totalScore += Score;
            GameController.instance.UpdateScoreText();
            AudioManager.instance.PlaySound(AudioManager.instance.fxOrangeCollected);
            Destroy(gameObject, 0.25f);
        }
    }
}
