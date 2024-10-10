using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shield : MonoBehaviour
{
    [SerializeField]
    private InputActionReference shieldButtonPress;
    private bool shieldDeployed = false;
    public GameObject shieldObj;

    public float shieldVal = 0;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        shieldVal = shieldButtonPress.action.ReadValue<float>();
        if (shieldVal > 0.5f)
        {
            shieldDeployed = true;
            shieldObj.SetActive(true);
        }
        else
        {
            shieldDeployed = false;
            shieldObj.SetActive(false);

        }
    }
    // void Deploy(InputAction.CallbackContext _){
    //     shieldDeployed = !shieldDeployed;
    //     if(shieldDeployed){
    //         gameObject.SetActive(true);
    //         shieldDeployed = false;
    //     }
    // }
}
