using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinandMove : MonoBehaviour
{

    public Transform parent;
    public float spinSpeed = 100f;
    public float moveSpeed = 3f;
    public float maxY = 10f;
    public float minY = 0f;
    public float ySpeed = 2f;

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Spin the object around its own axis
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);

        // Calculate the movement direction based on the parent's position
        Vector3 moveDirection = parent.position - transform.position;
        moveDirection.y = 0f; // Ignore vertical movement

        // Move the object based on the parent's position
        transform.Translate(moveDirection.normalized * moveSpeed * Time.deltaTime, Space.World);

        // Calculate the vertical movement based on the object's initial position
        float newY = Mathf.PingPong(Time.time * ySpeed, maxY - minY) + minY;
        Vector3 newPosition = new Vector3(transform.position.x, newY, transform.position.z);
        transform.position = newPosition;
    }
}
