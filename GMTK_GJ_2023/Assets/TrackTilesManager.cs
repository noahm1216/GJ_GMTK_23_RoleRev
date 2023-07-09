using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTilesManager : MonoBehaviour
{
    public GameObject straight_track_tile;
    public GameObject straight_dirt_tile;
    public GameObject straight2_track_tile;
    public GameObject straight2_dirt_tile;
    public GameObject straight3_track_tile;
    public GameObject straight3_dirt_tile;
    public GameObject straight4_track_tile;
    public GameObject straight4_dirt_tile;
    public GameObject hairpinleft_track_tile;
    public GameObject hairpinleft_dirt_tile;
    public GameObject hairpinright_track_tile;
    public GameObject hairpinright_dirt_tile;
    public GameObject slightleft_track_tile;
    public GameObject slightleft_dirt_tile;
    public GameObject slightright_track_tile;
    public GameObject slightright_dirt_tile;
    public GameObject tightsidewinderLR_track_tile;
    public GameObject tightsidewinderLR_dirt_tile;
    public GameObject tightsidewinderRL_track_tile;
    public GameObject tightsidewinderRL_dirt_tile;
    public GameObject loosesidewinderLR_track_tile;
    public GameObject loosesidewinderLR_dirt_tile;
    public GameObject loosesidewinderRL_track_tile;
    public GameObject loosesidewinderRL_dirt_tile;
    public GameObject gentleleft_track_tile;
    public GameObject gentleright_track_tile;
    public GameObject gentleleft_dirt_tile;
    public GameObject gentleright_dirt_tile;
    public GameObject uturnleft_track_tile;
    public GameObject uturnright_track_tile;
    public GameObject uturnleft_dirt_tile;
    public GameObject uturnright_dirt_tile;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //CreateTile takes a string for track type and a string for track terrain
    //Based on the parameters of the type of card that was played, this function
    //  instantiates a track tile based on on those parameters
    public void CreateTile(string track_type, string track_terrain)
    {
        Debug.Log("Creating Tile");
        //Instantiate(straight_tile);
        if (track_type == "Straight" && track_terrain == "Track") Instantiate(straight_track_tile);
        else if (track_type == "Straight" && track_terrain == "Dirt") Instantiate(straight_dirt_tile);
        else if (track_type == "HairpinLeft" && track_terrain == "Track") Instantiate(hairpinleft_track_tile);
        else if (track_type == "HairpinLeft" && track_terrain == "Dirt") Instantiate(hairpinleft_dirt_tile);
        else if (track_type == "HairpinRight" && track_terrain == "Track") Instantiate(hairpinright_track_tile);
        else if (track_type == "HairpinRight" && track_terrain == "Dirt") Instantiate(hairpinright_dirt_tile);
        else if (track_type == "SlightLeft" && track_terrain == "Track") Instantiate(slightleft_track_tile);
        else if (track_type == "SlightLeft" && track_terrain == "Dirt") Instantiate(slightleft_dirt_tile);
        else if (track_type == "SlightRight" && track_terrain == "Track") Instantiate(slightright_track_tile);
        else if (track_type == "SlightRight" && track_terrain == "Dirt") Instantiate(slightright_dirt_tile);
        else if (track_type == "Straight2" && track_terrain == "Track") Instantiate(straight2_track_tile);
        else if (track_type == "Straight2" && track_terrain == "Dirt") Instantiate(straight2_dirt_tile);
        else if (track_type == "Straight3" && track_terrain == "Track") Instantiate(straight3_track_tile);
        else if (track_type == "Straight3" && track_terrain == "Dirt") Instantiate(straight3_dirt_tile);
        else if (track_type == "Straight4" && track_terrain == "Track") Instantiate(straight4_track_tile);
        else if (track_type == "Straight4" && track_terrain == "Dirt") Instantiate(straight4_dirt_tile);
        else if (track_type == "GentleLeft" && track_terrain == "Track") Instantiate(gentleleft_track_tile);
        else if (track_type == "GentleRight" && track_terrain == "Track") Instantiate(gentleright_track_tile);
        else if (track_type == "GentleLeft" && track_terrain == "Dirt") Instantiate(gentleleft_dirt_tile);
        else if (track_type == "GentleRight" && track_terrain == "Dirt") Instantiate(gentleright_dirt_tile);
        else if (track_type == "UTurnLeft" && track_terrain == "Track") Instantiate(uturnleft_track_tile);
        else if (track_type == "UTurnLeft" && track_terrain == "Dirt") Instantiate(uturnleft_dirt_tile);
        else if (track_type == "UTurnRight" && track_terrain == "Track") Instantiate(uturnright_track_tile);
        else if (track_type == "UTurnRight" && track_terrain == "Dirt") Instantiate(uturnright_dirt_tile);
        else if (track_type == "TightSidewinderRL" && track_terrain == "Track") Instantiate(tightsidewinderRL_track_tile);
        else if (track_type == "TightSidewinderRL" && track_terrain == "Dirt") Instantiate(tightsidewinderRL_dirt_tile);
        else if (track_type == "TightSidewinderLR" && track_terrain == "Track") Instantiate(tightsidewinderLR_track_tile);
        else if (track_type == "TightSidewinderLR" && track_terrain == "Dirt") Instantiate(tightsidewinderLR_dirt_tile);
        else if (track_type == "LooseSidewinderRL" && track_terrain == "Track") Instantiate(loosesidewinderRL_track_tile);
        else if (track_type == "LooseSidewinderRL" && track_terrain == "Dirt") Instantiate(loosesidewinderRL_dirt_tile);
        else if (track_type == "LooseSidewinderLR" && track_terrain == "Track") Instantiate(loosesidewinderLR_track_tile);
        else if (track_type == "LooseSidewinderLR" && track_terrain == "Dirt") Instantiate(loosesidewinderLR_dirt_tile);
        else Debug.Log("You missed one...");
    }
}
