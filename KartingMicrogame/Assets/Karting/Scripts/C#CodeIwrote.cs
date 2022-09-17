// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class C#CodeIwrote : MonoBehaviour
// {
//
// // ArcadeKart Class
// // SpeedBoost
// private float timer;
// private void OnTriggerEnter(Collider other)
// {
//     if (other.tag == "potion")
//     {
//         Debug.Log("Inside");
//         timer += 1f + Time.deltaTime;
//         Debug.Log(timer);
//         if (timer >= 2f)
//         {
//             gameObject.GetComponent<Rigidbody>().velocity /= 2f;
//             Debug.Log("Back to Normal");
//         }
//     }
//
//     // Stop if wall
//     if (other.CompareTag("Wall"))
//     {
//         gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,0f);
//         Debug.Log("You hit a wall!!!!");
//         Destroy(GameObject.FindWithTag("Wall"));
//     }
//             
// }
//
// // HalveSpeed Class
// public class SlowPotion : MonoBehaviour
// {
//     private void OnTriggerEnter(Collider other)
//     {
//         
//         if (other.CompareTag("Player"))
//         {
//             other.attachedRigidbody.velocity /= 2f;
//             Debug.Log("Speed is Halved!");
//             Destroy(gameObject);
//             
//         }
//         
//         
//     }
// }
//
// // SpeedBoost Class
//
// public class SpeedBoostPowerUp : MonoBehaviour
// {
//     ArcadeKart kart;
//     private bool accelerate;
//     
//     
//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             other.attachedRigidbody.velocity *= 2f;
//             Debug.Log("Speed is Doubled!");
//             Destroy(gameObject);
//         }
//         
//         
//     }
// }
//
// }
