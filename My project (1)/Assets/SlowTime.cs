using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public GameObject rightHandReference;

void Update() {
	// Your code to check what the time scale should be ;)
	Time.timeScale = 0.5f; // <- This will make the game move at half speed
}
}
