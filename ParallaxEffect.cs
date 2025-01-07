using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public Transform playerTransform; // Referência ao personagem
    public Vector2 parallaxMultiplier; // Velocidade de movimento da camada (eixo X e Y)

    private Vector3 lastPlayerPosition;

    void Start()
    {
        // Inicializa a posição do personagem
        lastPlayerPosition = playerTransform.position;
    }

    void Update()
    {
        // Calcula a diferença de posição do personagem desde o último frame
        Vector3 deltaMovement = playerTransform.position - lastPlayerPosition;

        // Move a camada com base no multiplicador de parallax
        transform.position += new Vector3(deltaMovement.x * parallaxMultiplier.x, deltaMovement.y * parallaxMultiplier.y, 0);

        // Atualiza a última posição do personagem
        lastPlayerPosition = playerTransform.position;
    }
}
