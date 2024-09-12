using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletTemplate;
    public float shootPower = 100f;

    public InputActionReference trigger;
    // Start is called before the first frame update
    void Start()
    {
        trigger.action.performed += Shoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot(InputAction.CallbackContext _){
        GameObject newBullet = Instantiate(BulletTemplate, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);

    }
}
