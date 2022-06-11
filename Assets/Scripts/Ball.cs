using UnityEngine;

public class Ball : MonoBehaviour
{
    // Defining the a speed variable to augment the movement of the ball
    public float speed = 200.0f;

    // Defining the Rigidbody2D variable _rigidbody for the ball 
    private Rigidbody2D _rigidbody;
    // and assigning it to the ball's Rigidbody2D component within the Awake method
    private void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called the very first frame that this script is executed
    private void Start() {
        ResetPosition();
        AddStartingForce();
    }
    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;

    }

    public void AddStartingForce()
    {
        // This will choose a random value between 0 and 1
        // If the value is less than 0.5, it will set the direction to left
        // If the value is greater than 0.5, it will set the direction to right
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        // This will choose a random value between 0 and 1
        // If the value is less than 0.5, it will set the y to a random number from the range of -1 to -0.5
        // If the value is greater than 0.5, it will set the y to a random number from the range of 0.5 to 1
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }
    // This will allow another object to add force to the ball
    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

    // This will allow us to reset the position and volocity to 0 when the game completes
    // Also re-add our starting force
}
