using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenu; // Arraste o PauseMenu no Inspector
    public static bool isPaused;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    // Função para pausar o jogo
    public void PauseGame()
    {
        Debug.Log("PauseGame chamado");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; // Pausa o tempo no jogo
        isPaused = true;
    }

    // Função para retomar o jogo
    public void ResumeGame()
    {
        Debug.Log("ResumeGame chamado");
        pauseMenu.SetActive(false); // Esconde o menu de pausa
        isPaused = false;
        Time.timeScale = 1f; // Retorna o tempo ao normal
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
        ResumeGame();
    }

    // Função para voltar ao menu principal
    public void BackToMainMenu()
    {
        Debug.Log("Voltando para o menu principal...");
        Time.timeScale = 1f; // Garante que o tempo esteja normal
        SceneManager.LoadScene("mainMenu");
        isPaused = false;
    }

    // Função para sair do jogo
    public void QuitGame()
    {
        Debug.Log("Saindo do Jogo...");
        Application.Quit();
    }
}
