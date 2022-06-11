using UnityEngine;
    // Using the UnityEngine/EventSystems namespace to access the EventTrigger.TrigerEvent method
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    // Defining the scoreTrigger
    public EventTrigger.TriggerEvent scoreTrigger;
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        // collision.gameObject will give us the object that collided with this object
        // GetComponent<Ball> will attempt to get the Ball component from the collided object
        Ball ball = collision.gameObject.GetComponent<Ball>();
        // If the ball is not null, then we know the collided object was the ball    
        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            // Triggering this event
            this.scoreTrigger.Invoke(eventData);
        }
    }
}
