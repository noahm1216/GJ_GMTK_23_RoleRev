using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexID : MonoBehaviour
{
    public Transform ghostHex;
    private Vector3 ghostHexStartPos;


    void OnMouseOver()
    {
        ghostHex.position = transform.position;
    }

    void OnMouseExit()
    {
        ghostHex.position = ghostHexStartPos;
    }
}
