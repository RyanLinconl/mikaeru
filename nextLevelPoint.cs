using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelPoint : MonoBehaviour
{

    public string lvlName;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(lvlName);
        }
    }
}
