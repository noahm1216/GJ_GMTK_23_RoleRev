using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTileSpawner : MonoBehaviour
{
    [Tooltip("The different single pieces to fill up grass and atmosphere")]
    [SerializeField] List<GameObject> hexGrassPieces = new List<GameObject>();
    [Tooltip("width and height of the entire grid")]
    [SerializeField] private Vector2 hexGridWxL;
    [Tooltip("width and height of a single tile")]
    [SerializeField] private Vector2 indieTileWxH;
    [Tooltip("The starting position of the grid")]
    [SerializeField] private Vector3 gridStartPosition;
    [Tooltip("Choose if you want the center of the grid to be the start position")]
    [SerializeField] private bool centerTheGrid;

    private Transform tileParent;
    [SerializeField] List<GameObject> HexGrassClones = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        if (tileParent == null)
        {
            tileParent = new GameObject("Hex Tile Parent").transform;
            tileParent.parent = transform;
        }

        SpawnHexGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //a function to spawn the grid
    public void SpawnHexGrid()
    {
        Vector3 gridOffset = new Vector3(0, 0, 0);
        int totalCount = 0;

        for (int iZ = 0; iZ < hexGridWxL.y; iZ++) //loop z tiles
        {
            for (int iX = 0; iX < hexGridWxL.x; iX++) //loop x tiles
            {
                gridOffset.x = gridStartPosition.x + (indieTileWxH.x * iX); //right by X amount
                gridOffset.y = gridStartPosition.y; // since 3d flat, we dont need this
                gridOffset.z = gridStartPosition.z - (indieTileWxH.y * iZ); // this should be gridOffset.y (if you want 2D)
                //for hex grid checking
                if (iX % 2 == 1) // Is odd, should offset
                    gridOffset.z -= (indieTileWxH.y);

                //if we want to center the grid
                // if (centerTheGrid) { gridOffset.x *= }


                GameObject hexGrassClone = Instantiate(hexGrassPieces[0], gridOffset, hexGrassPieces[0].transform.rotation);
                hexGrassClone.transform.name += "_" + (totalCount).ToString() + "_" + gridOffset.ToString();
                hexGrassClone.transform.parent = tileParent;
                totalCount++;
            }//end of loop x tiles

        }//end of loop z tiles


    }//end of SpawnHexGrid()


}//end of HexTileSpawner
