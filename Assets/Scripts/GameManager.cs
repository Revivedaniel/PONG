using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    // Defining the score variables
    private int _playerScore;
    private int _computerScore;

    // These methods will be called when either the player or computer scores
    public void PlayerScores()
    {
        _playerScore++;
        Debug.Log(_playerScore);
        
        this.ball.ResetPosition();
    }

    public void ComputerScores()
    {
        _computerScore++;
        Debug.Log(_computerScore);

        this.ball.ResetPosition();
    }

    
}
