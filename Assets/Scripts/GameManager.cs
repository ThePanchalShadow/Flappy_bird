using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public void StartGame()
    {
        gameHasEnded = false;
        SceneManager.LoadScene(1); 
    }
    public void Restart()
    {
        if(!gameHasEnded)
        {
            gameHasEnded = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
