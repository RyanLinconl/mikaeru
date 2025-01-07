using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private AudioSource audioSource;

    [Header("Lista de Sons")]

    public AudioSource _fxGame;
    public AudioClip fxJump;
    public AudioClip fxTrampoline;
    public AudioClip fxDeathSpike;
    public AudioClip fxDeathEnemy;
    public AudioClip fxOrangeCollected;

    void Awake()
    {
        // Garante que apenas um AudioManager exista na cena
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Persiste entre cenas
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}