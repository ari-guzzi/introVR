using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class EnemyShooting : MonoBehaviour
{    
   [SerializeField] private GameObject enemyBullet;
   [SerializeField] private Transform shootingPoint;
   [SerializeField] private float shootingRate = 3.0f;
   [SerializeField] private float shootPower = 500f;

    private GameObject playerTarget;
    private float shootingTimer = 1.0f;
    // public TextMeshProUGUI debugText;
    public AudioClip enemyShootingSFX;
// When the player enters the trigger, assign it as a target
// private void OnTriggerEnter(Collider other) {
//     playerTarget = other.gameObject;
//     //GameOver();
// }

// Update is called once per frame
void Update()
{
    if (shootingPoint != null) {
        transform.LookAt(shootingPoint.position);
        // debugText.text = "Enemy aiming at player at: " + playerTarget.transform.position.ToString();
         if (shootingTimer <= 0) { //shoot when timer runs out
         
                GameObject newBullet = Instantiate(enemyBullet, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);
                GetComponent<AudioSource>().PlayOneShot(enemyShootingSFX); //if we wanted more than one audio clip in code

                shootingTimer = shootingRate; //increase timer back to 5
            }
            shootingTimer -= Time.deltaTime; //decrease shooting timer
        }

    }
    
}