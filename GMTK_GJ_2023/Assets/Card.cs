using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public enum TrackTurnAngle { HairpinLeft, SlightLeft, Straight, SlightRight, HairpinRight,
                                 TightSidewinderRL, TightSidewinderLR, LooseSidewinderRL, LooseSidewinderLR,
                                 GentleLeft, GentleRight, UTurnLeft, UTurnRight,
                                 Straight2, Straight3, Straight4 };
    [SerializeField] public TrackTurnAngle cardTrackType;
    public enum TrackSpecialty { Speed, Handling, OffRoad };
    [SerializeField] public TrackSpecialty trackSpecialty;
    public enum TrackTerrain { Track, Dirt };
    [SerializeField] public TrackTerrain trackTerrain;
    public enum TrackSpecial { none };
    [SerializeField] public TrackSpecial trackSpecial;

    public Text text_cardTitle;
    public Text text_BestForText;
    public Text text_TypeText;
    public Text text_SpecialText;
    public Image trackImage_object;
    public Sprite trackImage;
    public string cardTitle;
    public string cardDescription;

    // Start is called before the first frame update
    void Start()
    {
        trackImage = GetComponentInChildren<Image>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTrackType(TrackTurnAngle givenTrackType)
    {
        cardTrackType = givenTrackType;
    }

    public void SetTrackImage()
    {
        //gameObject.GetComponentInChildren<Image>().sprite = trackImage;
        trackImage_object.sprite = trackImage;
    }

    public void SetTrackSpecialty()
    {
        //trackSpecialty = (TrackSpecialty)Random.Range(0, 3);
        if (trackTerrain == TrackTerrain.Dirt) trackSpecialty = TrackSpecialty.OffRoad;
        else if (trackTerrain == TrackTerrain.Track)
        {
            if (cardTrackType == TrackTurnAngle.Straight ||
                cardTrackType == TrackTurnAngle.Straight2 ||
                cardTrackType == TrackTurnAngle.Straight3 ||
                cardTrackType == TrackTurnAngle.Straight4)
            {
                trackSpecialty = TrackSpecialty.Speed;
            }
            else
            {
                trackSpecialty = TrackSpecialty.Handling;
            }
        }

        text_BestForText.text = trackSpecialty.ToString();
    }

    public void SetTrackTerrain()
    {
        trackTerrain = (TrackTerrain)Random.Range(0, 2);
        text_TypeText.text = trackTerrain.ToString();
    }

    public void SetTrackSpecial()
    {
        trackSpecial = TrackSpecial.none;
        text_SpecialText.text = trackSpecial.ToString();
    }

    public void SetTrackTitle(string givenTitle)
    {
        if (givenTitle == "Straight") cardTitle = "Straight";
        else if (givenTitle == "Straight2") cardTitle = "Straight 2";
        else if (givenTitle == "Straight3") cardTitle = "Straight 3";
        else if (givenTitle == "Straight4") cardTitle = "Straight 4";
        else if (givenTitle == "SlightLeft") cardTitle = "Slight Left";
        else if (givenTitle == "SlightRight") cardTitle = "Slight Right";
        else if (givenTitle == "HairpinLeft") cardTitle = "Hairpin Left";
        else if (givenTitle == "HairpinRight") cardTitle = "Hairpin Right";
        else if (givenTitle == "TightSidewinderLR") cardTitle = "Tight Sidewinder LR";
        else if (givenTitle == "TightSidewinderRL") cardTitle = "Tight Sidewinder RL";
        else if (givenTitle == "LooseSidewinderLR") cardTitle = "Loose Sidewinder LR";
        else if (givenTitle == "LooseSidewinderRL") cardTitle = "Loose Sidewinder RL";
        else if (givenTitle == "UTurnLeft") cardTitle = "U-Turn Left";
        else if (givenTitle == "UTurnRight") cardTitle = "U-Turn Right";
        else if (givenTitle == "GentleLeft") cardTitle = "Gentle Left";
        else if (givenTitle == "GentleRight") cardTitle = "Gentle Right";
        else cardTitle = "You missed one...";
        text_cardTitle.text = cardTitle;
    }

    public void RandomlyDecideTrackTurnAngle()
    {
        cardTrackType = (TrackTurnAngle)Random.Range(0, 16);
        SetTrackTitle(cardTrackType.ToString());
    }
}
