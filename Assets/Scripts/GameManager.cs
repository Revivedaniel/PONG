using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;
    // Defining the score variables
    private int _playerScore;
    private int _computerScore;

    // These methods will be called when either the player or computer scores
    public void PlayerScores()
    {
        _playerScore++;
        // Setting the player score text to the current score
        this.playerScoreText.text = _playerScore.ToString();        
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void ComputerScores()
    {
        _computerScore++;
        // Setting the computer score text to the current score
        this.computerScoreText.text = _computerScore.ToString();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    
}
