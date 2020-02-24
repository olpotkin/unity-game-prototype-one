using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public float restartDelay = 2f;
    public GameObject completeLevelUI;

    bool gameHasEnded = false;
    

    public void FinishLevel()
    {
        //Debug.Log("LEVEL WON!");
        completeLevelUI.SetActive(true);
    }


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");

            // Restart game with delay
            Invoke("RestartGame", restartDelay);
        }
    }


    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
