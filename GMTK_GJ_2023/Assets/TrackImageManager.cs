using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackImageManager : MonoBehaviour
{
    public List<Sprite> trackimages_hairpinleft  = new List<Sprite>();
    public List<Sprite> trackimages_hairpinright = new List<Sprite>();
    public List<Sprite> trackimages_slightleft   = new List<Sprite>();
    public List<Sprite> trackimages_slightright  = new List<Sprite>();
    public List<Sprite> trackimages_straight     = new List<Sprite>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite SetTrackImage(string track_type, string terrain_type)
    {
        if (track_type == "Straight"  ||
            track_type == "Straight2" ||
            track_type == "Straight3" ||
            track_type == "Straight4")
        {
            if (terrain_type == "Track") return trackimages_straight[0];
            else return trackimages_straight[1];
        }

        else if (track_type == "SlightLeft" ||
                 track_type == "LooseSidewinderLR" ||
                 track_type == "GentleLeft")
        {
            if (terrain_type == "Track") return trackimages_slightleft[0];
            else return trackimages_slightleft[1];
        }

        else if (track_type == "SlightRight" ||
                 track_type == "LooseSidewinderRL" ||
                 track_type == "GentleRight")
        {
            if (terrain_type == "Track") return trackimages_slightright[0];
            else return trackimages_slightright[1];
        }

        else if (track_type == "HairpinLeft" ||
                 track_type == "TightSidewinderLR" ||
                 track_type == "UTurnLeft")
        {
            if (terrain_type == "Track") return trackimages_hairpinleft[0];
            else return trackimages_hairpinleft[1];
        }

        else
        {
            if (terrain_type == "Track") return trackimages_hairpinright[0];
            else return trackimages_hairpinright[1];
        }
    }
}
