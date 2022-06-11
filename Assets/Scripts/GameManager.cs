using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int _playerScore;
    private int _computerScore;

    // These methods will be called when either the player or computer scores
    public void PlayerScores()
    {
        _playerScore++;
        // Setting the player score text to the current score
        this.playerScoreText.text = _playerScore.ToString();  
        resetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        // Setting the computer score text to the current score
        this.computerScoreText.text = _computerScore.ToString();
        resetRound();
    }

    private void resetRound()
    {
        this.playerPaddle.resetPosition();     
        this.computerPaddle.resetPosition();     
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    
}
