using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void GameOver()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        gameEnded = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }

}
