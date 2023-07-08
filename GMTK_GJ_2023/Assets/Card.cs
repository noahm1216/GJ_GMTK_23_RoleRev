using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public enum TrackType { SouthWest, NorthWest, North, NorthEast, SouthEast};
    [SerializeField] TrackType cardTrackType;

    public Text text_cardDescription;
    public Text text_cardTitle;
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

    public void SetTrackType(TrackType givenTrackType)
    {
        cardTrackType = givenTrackType;
    }

    public void SetTrackImage(Image givenTrackImage)
    {
        trackImage = givenTrackImage;
    }

    public void SetTrackDescription(string givenDescription)
    {
        cardDescription = givenDescription;
        text_cardDescription.text = cardDescription;
    }

    public void SetTrackTitle(string givenTitle)
    {
        cardTitle = givenTitle;
        text_cardTitle.text = cardTitle;
    }

    public void RandomlyDecideTrackType()
    {
        cardTrackType = (TrackType)Random.Range(0, 4);
    }
}
