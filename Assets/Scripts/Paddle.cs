using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Defining the a speed variable to augment the movement of the paddle
    // This variable is public so that we can see an input right in the unity editor
    public float speed = 10.0f;
    // Defining an empty variable called _rigidbody of type Rigidbody2D
    // Variable is protected so that inheritor classes can also access it but its still private
    protected Rigidbody2D _rigidbody;

    // Unity will call Awake() 1 time in its life cycle and is used to initialize variables
    private void Awake()
    {
        // GetComponent will search on the same object the script is attached to to look for the component specified
        // will return it and assign it to the _rigidbody varable.
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void resetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector2.zero;
    }
}
