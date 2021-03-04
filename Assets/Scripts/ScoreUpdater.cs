using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    // The actual GUI text
    public Text scoreText;
    public Text waveText;

   

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        UpdateWave();
    }


    public void UpdateScore()
    {
        scoreText.text = "SCORE: " + ScoreController.scoreVal;
    }

    public void UpdateWave()
    {
        waveText.text = ScoreController.waveNumber + " :WAVE";
    }

    
}
