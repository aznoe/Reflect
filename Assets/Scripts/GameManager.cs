using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameOverScreen gameOverScreen;
    bool gameHasEnded = false;


    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            gameOverScreen.SetUp(ScoreController.scoreVal, ScoreController.waveNumber);
            
        }

    }

}
