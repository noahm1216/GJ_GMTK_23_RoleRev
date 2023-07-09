using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTool_LineRen : MonoBehaviour
{
    [SerializeField] private Transform transStart, transEnd;
    [SerializeField] private LineRenderer linRend;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        linRend.SetPosition(0, transStart.position);
        linRend.SetPosition(1, transEnd.position);

    }
}
