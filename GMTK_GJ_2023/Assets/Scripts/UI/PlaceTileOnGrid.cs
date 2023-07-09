using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTileOnGrid : MonoBehaviour
{
    public GameObject myTileToPlace;
    public bool canRotate;
    public GameObject myRotCanvas;
    public Transform myRotatingParent;
    public float rotateSpeed = 10;

    public GameObject gabrielsCardObjs;
    public Transform stationaryParent;
    public GameObject racerButton;
    public int tilesPlaced = 0;

    // Update is called once per frame
    void Update()
    {
        myRotCanvas.SetActive(canRotate);

        if (canRotate)
        {
            if(Input.GetKeyDown("right") || Input.GetKeyDown("d") || Input.GetKeyDown("e") || Input.GetMouseButtonDown(1)) // rotate right
            {
                Rotate(true);
            }

            if (Input.GetKeyDown("left") || Input.GetKeyDown("a") || Input.GetKeyDown("q")||  Input.GetMouseButtonDown(2)) // rotate left
            {
                Rotate(false);
            }

            //if click, or hit enter then done
            if (Input.GetKeyDown("return") || Input.GetKeyDown("escape") || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Escape))  //if click, or hit enter then done
            {
                PlaceConfirm();
            }

        }//end of can rotate
        else
        {
            if (Input.GetMouseButtonDown(0) && myTileToPlace != null )//if we click and have a tile
            {
                //print("clicking 0");
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 1000.0f))
                {
                    //Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                    //print($"Clicked: {hit.transform.name}");

                    if (hit.transform.tag == ("FreeTile"))
                    {
                        print($"Clicked: {hit.transform.name}");
                        //place the tile
                        PlaceTileHere(hit.transform);
                        hit.transform.tag = "OccupiedTile";
                        canRotate = true;
                    }

                }

            }

            //can move while we cant rotate
            if (Input.GetKey("right") || Input.GetKey("d") || Input.GetKey("e") || Input.GetMouseButton(1)) // rotate right
            {
                myRotatingParent.transform.Rotate(0, -90*Time.deltaTime * rotateSpeed, 0);
            }//end of right
            if (Input.GetKey("left") || Input.GetKey("a") || Input.GetKey("q") || Input.GetMouseButton(2)) // rotate left
            {
                myRotatingParent.transform.Rotate(0, 90 * Time.deltaTime * rotateSpeed, 0);
            }//end of left

        }//end of cannot rotate
        

    }//end of update


    //a function to place the tile and enter rotation mode
    private void PlaceTileHere(Transform hitTile)
    {
        myTileToPlace.transform.position = hitTile.position + new Vector3(0,0.5f,0);
        myTileToPlace.transform.rotation = hitTile.rotation;
        canRotate = true;
    }

    public void Rotate(bool turnRight)
    {
        int isRight = 1;
        if (!turnRight) isRight = -1;

        myTileToPlace.transform.Rotate(0, 60*isRight, 0);
    }

    public void PlaceConfirm()
    {
        print("Tile Place");
        tilesPlaced++;
        myTileToPlace.transform.SetParent(stationaryParent);
        //places the tile and moves onto the next
        myTileToPlace = null;
        canRotate = false;
        gabrielsCardObjs.SetActive(true);

        if (tilesPlaced >= 2)
            racerButton.SetActive(true);
    }

    public void ReplaceMyTile(GameObject _newTile)
    {
        myTileToPlace = _newTile;
        myTileToPlace.transform.SetParent(transform.parent);
        gabrielsCardObjs.SetActive(false);
    }



}//end of place tile on grid script
