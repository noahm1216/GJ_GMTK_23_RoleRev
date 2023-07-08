using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveZDirection : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        // Move the object in the z-direction
        float moveDistance = moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveDistance);
    }
}
