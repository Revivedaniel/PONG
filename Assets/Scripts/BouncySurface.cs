using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    // Defining a bounceStrength for easy manipulation
    public float bounceStrength;

    // This function is called whenever another object with a rigidbody2D collides with this object
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        // collision.gameObject will give us the object that collided with this object
        // GetComponent<Ball> will attempt to get the Ball component from the collided object
        Ball ball = collision.gameObject.GetComponent<Ball>();
        // If the ball is not null, then we know the collided object was the ball    
        if (ball != null)
        {
            // GetContact(0) gets the contact point of this object and the collided object
            // Since GetContact returns a list, we will select the first in the list using index 0
            // .normal will get the vector pointing away from the collided object
            Vector2 normal = collision.GetContact(0).normal;
            // Adding force to the ball with our Vector2 and the bounceStrength
            // -normal will make the force point away from the collided object
            ball.AddForce(-normal * bounceStrength);
        }
    }
}
