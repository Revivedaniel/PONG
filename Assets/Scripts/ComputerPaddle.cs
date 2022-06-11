using UnityEngine;

public class ComputerPaddle : Paddle
{
    // Defining the rigidbody2D variable for the ball
    // This is public so we can assign the ball rigidbody2D in the inspector within Unity
    public Rigidbody2D ball;
    private void FixedUpdate() 
    {
        // If the balls x direction is positive, that means the ball is moving to the right
        // Since the computer paddle is on the right then this would mean the ball is moving toward the computer paddle
        if (this.ball.velocity.x > 0.0f) {
            // If the balls y position is greater than the computers y position, then the computer paddle is below the ball
            // This means the computer paddle should move up
            if (this.ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            // If the balls y position is less than the computers y position, then the computer paddle is above the ball
            // This means the computer paddle should move down
            else if (this.ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        // If the balls c direction is not positive, that means the ball is moving to the left
        // Since the computer paddle is on the right that means the ball is moving toward the player paddle
        else{
            // If the computer paddle is above center, then move back to center
            if (this.transform.position.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
            // If the computer paddle is below center, then move back to center
            else if (this.transform.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
