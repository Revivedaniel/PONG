using UnityEngine;

public class PlayerPaddle : Paddle
{
    // This variable will keep track of the players direction
    private Vector2 _direction;

    // Unity calls this every frame the game is running
    // used for logic that needs to be executed every frame
    private void Update() 
    {
        // If the player presses the up arrow key or the w key, Set the direction to up
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            _direction = Vector2.up;
        }
        // If the player presses the down arrow key or the s key, Set the direction to down
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            _direction = Vector2.down;
        }
        // If the player does not press any of the given keys, Set the direction to zero
        else{
            _direction = Vector2.zero;
        }
    }

    // Called at a fixed time interval
    // Very much associated with physics
    private void FixedUpdate() 
    {
        // If the direction is not zero, move the paddle
        if (_direction.sqrMagnitude != 0)
        {
            // Move the paddle in the direction of the direction variable
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
