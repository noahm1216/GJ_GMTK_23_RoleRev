using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehavior : MonoBehaviour
{
    public enum RoadType //----------------TERRAIN
    {
        Normal, //if type is not NORMAL then IS terrain
        Dirt,
        Wet,
    }
    public RoadType thisRoadType;
    

    public enum CurveType//-----------------TURN TYPE
    {
        Straight, //if type is not Straight then no penalty
        SlightTurn,
        HardTurn,
    }
    public CurveType thisCurveType;

    [HideInInspector]
    public bool isTerrain, isCurved;

    public float speedMultiplier; // the speed effect from driving on this tile
    private float speedRoadType;
    private float speedCurveType;


    // Start is called before the first frame update
    void Start()
    {
        if (thisRoadType != RoadType.Normal)
            isTerrain = true;

        if (thisCurveType != CurveType.Straight)
            isCurved = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
