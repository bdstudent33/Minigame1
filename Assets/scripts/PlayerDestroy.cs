using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class DestroyOnCollision : MonoBehaviour
{
    public float delayBeforeDestroy = 3.0f; // Time to wait before destroying the object
    private ScoreManager scoreManager; // Reference to the ScoreManager

    private void Start()
    {
        // Find the ScoreManager in the scene
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that collided is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Start the destruction countdown
            StartCoroutine(DestroyAfterDelay());
        }
    }

    private System.Collections.IEnumerator DestroyAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delayBeforeDestroy);

        // Increment the score
        if (scoreManager != null)
        {
            scoreManager.IncrementScore();
        }

        // Destroy this GameObject
        Destroy(gameObject);
    }
}