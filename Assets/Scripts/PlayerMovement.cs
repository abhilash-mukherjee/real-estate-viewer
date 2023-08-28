using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed = 90.0f;
    public float moveSpeed = 5.0f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Rotation
        float rotationInput = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * rotationInput);

        // Movement in XZ plane
        float verticalInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        Vector3 moveDirection = transform.forward * verticalInput;

        controller.Move(moveDirection);
    }
}
