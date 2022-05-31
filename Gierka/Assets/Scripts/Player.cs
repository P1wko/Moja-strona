using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isKeyPressDown;
    private float horizontalInput;
    private Rigidbody rigibodyComponent;
    // Start is called before the first frame update
    void Start()
    {
        rigibodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isKeyPressDown = true;
        }
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if(isKeyPressDown)
        {
            rigibodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            isKeyPressDown = false;
        }
        rigibodyComponent.velocity = new Vector3(horizontalInput, rigibodyComponent.velocity.y, 0);
    }
}
