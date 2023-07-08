using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public enum TrackTurnAngle { HairpinLeft, SlightLeft, Straight, SlightRight, HairpinRight };
    [SerializeField] TrackTurnAngle cardTrackType;
    public enum TrackType { Speed, Handling, OffRoad };
    [SerializeField] TrackType trackType;
    public enum TrackTerrain { Track, Dirt };
    [SerializeField] TrackTerrain trackTerrain;
    public enum TrackSpecial { none };
    [SerializeField] TrackSpecial trackSpecial;

    public Text text_cardTitle;
    public Text text_BestForText;
    public Text text_TypeText;
    public Text text_SpecialText;
    public Image trackImage;
    public string cardTitle;
    public string cardDescription;

    // Start is called before the first frame update
    void Start()
    {
        trackImage = GetComponentInChildren<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTrackType(TrackTurnAngle givenTrackType)
    {
        cardTrackType = givenTrackType;
    }

    public void SetTrackImage(Image givenTrackImage)
    {
        trackImage = givenTrackImage;
    }

    public void SetTrackType()
    {
        trackType = (TrackType)Random.Range(0, 3);
        text_BestForText.text = trackType.ToString();
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
        cardTitle = givenTitle;
        text_cardTitle.text = cardTitle;
    }

    public void RandomlyDecideTrackTurnAngle()
    {
        cardTrackType = (TrackTurnAngle)Random.Range(0, 5);
        SetTrackTitle(cardTrackType.ToString());
    }
}
