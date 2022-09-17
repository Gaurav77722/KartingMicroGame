using KartGame.KartSystems;
using UnityEngine;

public class SpeedBoostPowerUp : MonoBehaviour
{
    ArcadeKart kart;
    private bool accelerate;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.attachedRigidbody.velocity *= 2f;
            Debug.Log("Speed is Doubled!");
            Destroy(gameObject);
        }
        
        
    }
}
