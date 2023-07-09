using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTool_LineRen : MonoBehaviour
{
    [SerializeField] private Transform transStart, transEnd;
    [SerializeField] private Transform boxStart, boxEnd;
    [SerializeField] private bool isVisible;
    private int presses = 0;



    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && presses == 0)
        {
            print("0");
            presses++;
            isVisible = true;
            Camera c1 = Camera.main;
            Vector3 p1 = c1.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, c1.nearClipPlane));
            transStart.position = p1;
            transEnd.position = p1;
        }

        if (Input.GetMouseButtonDown(0) && presses==1)
        {
            print("clicking 0");
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
              
                //Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                transEnd.position = hit.point;
                if (hit.transform != null)
                {
                    print("1");
                    isVisible = true;
                    presses++;
                }
            }
            
        }

        if (Input.GetMouseButtonDown(0) && presses == 2)
        {
            print("2");
            isVisible = false;
            presses = 0;
        }



        //linRend.gameObject.SetActive(isVisible);
        //if(!isVisible) return;

        //Camera c = Camera.main;
        //Vector3 p = c.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, c.nearClipPlane));
        //transEnd.position = p;        

        boxStart.position = transStart.position;
        boxEnd.position = transEnd.position;


       
    }
}
