using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float jumpForce = 23.0f;
    public float gravityModifier = 5.0f;
    public bool OnGroud = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnGroud)
        {
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            OnGroud = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        OnGroud = true;
    }
}
