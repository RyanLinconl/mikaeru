using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        // Troca para a cena da Fase 1
        SceneManager.LoadScene("lvl_1");
    }

    public void OpenCredits()
    {
        // Troca para a cena dos créditos
        SceneManager.LoadScene("Credit");
    }

    public void BackToMainMenu()
    {
        // Troca para a cena do Menu
        SceneManager.LoadScene("mainMenu");
    }

    public void QuitGame()
    {
        // Fecha o jogo
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }

}
