using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTilesManager : MonoBehaviour
{
    [Header("Noahs Master Plugins")]
    [Space]
    public Transform tileSpawnerLocation;
    public PlaceTileOnGrid tilePlaceScript;
    [HideInInspector]
    public GameObject tileClone;

    [Space]
    [Space]
    [Space]
    [Space]
    [Header("Gabriel's Handy Work")]
    [Space]
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



    //CreateTile takes a string for track type and a string for track terrain
    //Based on the parameters of the type of card that was played, this function
    //  instantiates a track tile based on on those parameters
    public void CreateTile(string track_type, string track_terrain)
    {
        Vector3 _newPos = new Vector3(0, 0, 0);
        if (tileSpawnerLocation != null) _newPos = tileSpawnerLocation.position;


        Debug.Log("Creating Tile");
        //Instantiate(straight_tile);
        if (track_type == "Straight" && track_terrain == "Track") { tileClone = Instantiate(straight_track_tile, _newPos, straight_track_tile.transform.rotation);  }
        else if (track_type == "Straight" && track_terrain == "Dirt") { tileClone = Instantiate(straight_dirt_tile, _newPos, straight_dirt_tile.transform.rotation);  }
        else if (track_type == "HairpinLeft" && track_terrain == "Track") { tileClone = Instantiate(hairpinleft_track_tile, _newPos, hairpinleft_track_tile.transform.rotation);  }
        else if (track_type == "HairpinLeft" && track_terrain == "Dirt") { tileClone = Instantiate(hairpinleft_dirt_tile, _newPos, hairpinleft_dirt_tile.transform.rotation);  }
        else if (track_type == "HairpinRight" && track_terrain == "Track") { tileClone = Instantiate(hairpinright_track_tile, _newPos, hairpinright_track_tile.transform.rotation);  }
        else if (track_type == "HairpinRight" && track_terrain == "Dirt") { tileClone = Instantiate(hairpinright_dirt_tile, _newPos, hairpinright_dirt_tile.transform.rotation);  }
        else if (track_type == "SlightLeft" && track_terrain == "Track") { tileClone = Instantiate(slightleft_track_tile, _newPos, slightleft_track_tile.transform.rotation);  }
        else if (track_type == "SlightLeft" && track_terrain == "Dirt") { tileClone = Instantiate(slightleft_dirt_tile, _newPos, slightleft_dirt_tile.transform.rotation);  }
        else if (track_type == "SlightRight" && track_terrain == "Track") { tileClone = Instantiate(slightright_track_tile, _newPos, slightright_track_tile.transform.rotation);  }
        else if (track_type == "SlightRight" && track_terrain == "Dirt") { tileClone = Instantiate(slightright_dirt_tile, _newPos, slightright_dirt_tile.transform.rotation);  }
        else if (track_type == "Straight2" && track_terrain == "Track") { tileClone = Instantiate(straight2_track_tile, _newPos, straight2_track_tile.transform.rotation);  }
        else if (track_type == "Straight2" && track_terrain == "Dirt") { tileClone = Instantiate(straight2_dirt_tile, _newPos, straight2_dirt_tile.transform.rotation);  }
        else if (track_type == "Straight3" && track_terrain == "Track") { tileClone = Instantiate(straight3_track_tile, _newPos, straight3_track_tile.transform.rotation);  }
        else if (track_type == "Straight3" && track_terrain == "Dirt") { tileClone = Instantiate(straight3_dirt_tile, _newPos, straight3_dirt_tile.transform.rotation);  }
        else if (track_type == "Straight4" && track_terrain == "Track") { tileClone = Instantiate(straight4_track_tile, _newPos, straight4_track_tile.transform.rotation);  }
        else if (track_type == "Straight4" && track_terrain == "Dirt") { tileClone = Instantiate(straight4_dirt_tile, _newPos, straight4_dirt_tile.transform.rotation);  }
        else if (track_type == "GentleLeft" && track_terrain == "Track") { tileClone = Instantiate(gentleleft_track_tile, _newPos, gentleleft_track_tile.transform.rotation);  }
        else if (track_type == "GentleRight" && track_terrain == "Track") { tileClone = Instantiate(gentleright_track_tile, _newPos, gentleright_track_tile.transform.rotation);  }
        else if (track_type == "GentleLeft" && track_terrain == "Dirt") { tileClone = Instantiate(gentleleft_dirt_tile, _newPos, gentleleft_dirt_tile.transform.rotation);  }
        else if (track_type == "GentleRight" && track_terrain == "Dirt") { tileClone = Instantiate(gentleright_dirt_tile, _newPos, gentleright_dirt_tile.transform.rotation);  }
        else if (track_type == "UTurnLeft" && track_terrain == "Track") { tileClone = Instantiate(uturnleft_track_tile, _newPos, uturnleft_track_tile.transform.rotation);  }
        else if (track_type == "UTurnLeft" && track_terrain == "Dirt") { tileClone = Instantiate(uturnleft_dirt_tile, _newPos, uturnleft_dirt_tile.transform.rotation);  }
        else if (track_type == "UTurnRight" && track_terrain == "Track") { tileClone = Instantiate(uturnright_track_tile, _newPos, uturnright_track_tile.transform.rotation);  }
        else if (track_type == "UTurnRight" && track_terrain == "Dirt") { tileClone = Instantiate(uturnright_dirt_tile, _newPos, uturnright_dirt_tile.transform.rotation);  }
        else if (track_type == "TightSidewinderRL" && track_terrain == "Track") { tileClone = Instantiate(tightsidewinderRL_track_tile, _newPos, tightsidewinderRL_track_tile.transform.rotation);  }
        else if (track_type == "TightSidewinderRL" && track_terrain == "Dirt") { tileClone = Instantiate(tightsidewinderRL_dirt_tile, _newPos, tightsidewinderRL_dirt_tile.transform.rotation);  }
        else if (track_type == "TightSidewinderLR" && track_terrain == "Track") { tileClone = Instantiate(tightsidewinderLR_track_tile, _newPos, tightsidewinderLR_track_tile.transform.rotation);  }
        else if (track_type == "TightSidewinderLR" && track_terrain == "Dirt") { tileClone = Instantiate(tightsidewinderLR_dirt_tile, _newPos, tightsidewinderLR_dirt_tile.transform.rotation);  }
        else if (track_type == "LooseSidewinderRL" && track_terrain == "Track") { tileClone = Instantiate(loosesidewinderRL_track_tile, _newPos, loosesidewinderRL_track_tile.transform.rotation);  }
        else if (track_type == "LooseSidewinderRL" && track_terrain == "Dirt") { tileClone = Instantiate(loosesidewinderRL_dirt_tile, _newPos, loosesidewinderRL_dirt_tile.transform.rotation);  }
        else if (track_type == "LooseSidewinderLR" && track_terrain == "Track") { tileClone = Instantiate(loosesidewinderLR_track_tile, _newPos, loosesidewinderLR_track_tile.transform.rotation);  }
        else if (track_type == "LooseSidewinderLR" && track_terrain == "Dirt") { tileClone = Instantiate(loosesidewinderLR_dirt_tile, _newPos, loosesidewinderLR_dirt_tile.transform.rotation);  }
        else Debug.Log("You missed one...");


        if (tileClone != null)
        {
            //tilePlaceScript.myTileToPlace = tileClone;
            tilePlaceScript.ReplaceMyTile(tileClone);
        }
            

    }
}
