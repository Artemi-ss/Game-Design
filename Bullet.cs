using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    
    /// <summary>
    /// Sent when other object enters trigger collider attached to this object
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision. </param>
    void OnTriggerEnter2D(Collider2D other)
    {
        switch(other.gameObject.tag)
        {
            case "Walls":
            Destroy(gameObject);
            break;
            case "Enemy":
            Destroy(gameObject);
            break;

        }
    }
}
