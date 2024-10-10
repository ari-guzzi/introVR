using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class ManagingAI : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private float speed = 5f;

private GameObject playerTarget;
public AudioClip collisionSFX;
// When the player enters the trigger, assign it as a target
private void OnTriggerEnter(Collider other) {
    playerTarget = other.gameObject;
}

// Update is called once per frame
void Update()
{
    // Only move forward if there is a player target
    if (playerTarget != null) {
		transform.LookAt(playerTarget.transform.position);
       transform.position += transform.forward * Time.deltaTime * speed;
        GetComponent<AudioSource>().PlayOneShot(collisionSFX); //if we wanted more than one audio clip in code

    }
}
}
