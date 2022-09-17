using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowPotion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            other.attachedRigidbody.velocity /= 2f;
            Debug.Log("Speed is Halved!");
            Destroy(gameObject);
            
        }
        
        
    }
}
