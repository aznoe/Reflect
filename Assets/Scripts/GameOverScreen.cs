using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public Text waveText;

    public void SetUp(int score, int wave)
    {
        gameObject.SetActive(true);
        pointsText.text = "SCORE "+ score.ToString();
        waveText.text = "WAVE: " + wave.ToString();
    }


    public void RestartButton()
    {
        ScoreController.scoreVal = 0;
        ScoreController.waveNumber = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenuButton()
    {
        ScoreController.scoreVal = 0;
        ScoreController.waveNumber = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }



}
