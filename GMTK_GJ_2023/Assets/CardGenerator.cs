using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardGenerator : MonoBehaviour
{
    public enum TrackTurnType { SouthWest, NorthWest, North, NorthEast, SouthEast };

    public GameObject cardPrefab;
    public GameObject trackImageManager_gameobject;
    private TrackImageManager trackImageManager;

    //3 Card Locations for them to be organized by
    private Vector3[] cardLocations = { new Vector3(-300, 0, 1), new Vector3(-150, 0, 1), new Vector3(0, 0, 1), new Vector3(150, 0, 1), new Vector3(300, 0, 1) };

    //Container for Dealt Cards for reference
    private List<GameObject> dealtCards = new List<GameObject>();

    public int cardsPlayed = 3;
    public int cardsDiscarded = 0;

    // Start is called before the first frame update
    void Start()
    {
        trackImageManager = trackImageManager_gameobject.GetComponent<TrackImageManager>();
        //start with three played cards to enable first hand draw
        cardsPlayed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealCards()
    {
        if (cardsPlayed < 3)
        {
            Debug.Log("You need to play 3 cards before you can be dealt a new hand!");
        }
        else
        {
            if (dealtCards.Count != 0)
            {
                foreach (GameObject g in dealtCards)
                {
                    Destroy(g);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Debug.Log("Dealing card: " + i);
                GameObject newCard = Instantiate(cardPrefab, transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform) as GameObject;
                dealtCards.Add(newCard);
                RectTransform rt = newCard.GetComponent<RectTransform>();
                rt.anchoredPosition = cardLocations[i];
                Card cardref = newCard.GetComponent<Card>();
                cardref.RandomlyDecideTrackTurnAngle();
                cardref.SetTrackTerrain();
                cardref.SetTrackSpecial(); //special is always "none" for now
                cardref.SetTrackSpecialty();
                cardref.trackImage = trackImageManager.SetTrackImage(cardref.cardTrackType.ToString(), cardref.trackTerrain.ToString());
                cardref.SetTrackImage();
            }
            cardsPlayed = 0;
            cardsDiscarded = 0;
        }
    }
}
