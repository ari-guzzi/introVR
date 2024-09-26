using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyShooting : MonoBehaviour
{    
   [SerializeField] private GameObject enemyBullet;
   [SerializeField] private Transform shootingPoint;
   [SerializeField] private float shootingRate = 3.0f;
   [SerializeField] private float shootPower = 500f;

    private GameObject playerTarget;
    private float shootingTimer;
    // public TextMeshProUGUI debugText;

// When the player enters the trigger, assign it as a target
private void OnTriggerEnter(Collider other) {
    playerTarget = other.gameObject;
    //GameOver();
}

// Update is called once per frame
void Update()
{
    if (playerTarget != null) {
        transform.LookAt(playerTarget.transform.position);
        // debugText.text = "Enemy aiming at player at: " + playerTarget.transform.position.ToString();
         if (shootingTimer <= 0) { //shoot when timer runs out
         
                GameObject newBullet = Instantiate(enemyBullet, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);

                shootingTimer = shootingRate; //increase timer back to 5
            }
            shootingTimer -= Time.deltaTime; //decrease shooting timer
        }

    }
    
}