using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public bool grounded;
    public float jumpForce;

    private Collider PlayerCollider;
    private Rigidbody PlayerRigidBody;

	// Use this for initialization
	void Start () {
        PlayerCollider = GetComponent<Collider>();
        PlayerRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 newPos = new Vector3(PlayerRigidBody.transform.position.x, PlayerRigidBody.transform.position.y, PlayerRigidBody.transform.position.z + 2.0f);
            PlayerRigidBody.transform.position = newPos;
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 newPos = new Vector3(PlayerRigidBody.transform.position.x, PlayerRigidBody.transform.position.y, PlayerRigidBody.transform.position.z - 2.0f);
            PlayerRigidBody.transform.position = newPos;
        }else if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerRigidBody.velocity = Vector3.up * jumpForce;
        }
	}
}
