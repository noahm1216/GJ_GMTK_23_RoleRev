using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardGenerator : MonoBehaviour
{
    public enum TrackType { SouthWest, NorthWest, North, NorthEast, SouthEast };

    public GameObject cardPrefab;

    //3 Card Locations for them to be organized by
    private Vector3[] cardLocations = { new Vector3(-180, 0, 1), new Vector3(0, 0, 1), new Vector3(180, 0, 1) };

    //Random Container for card descriptions
    private string[] cardDescriptions = { "Description 1", "Description 2", "Description 3" };

    //Random Container for card titles
    private string[] cardTitles = { "Title 1", "Title 2", "Title 3" };

    // Start is called before the first frame update
    void Start()
    {
        //GameObject newCard = Instantiate(cardPrefab, transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform) as GameObject;
        //RectTransform rt = newCard.GetComponent<RectTransform>();
        //rt.anchoredPosition = cardLocations[0];
        //Card cardref = newCard.GetComponent<Card>();
        //cardref.SetTrackDescription("Test description");
        //cardref.SetTrackType(Card.TrackType.SouthWest);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealCards()
    {
        for(int i = 0; i < 3; i++)
        {
            Debug.Log("Dealing card: " + i);
            GameObject newCard = Instantiate(cardPrefab, transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform) as GameObject;
            RectTransform rt = newCard.GetComponent<RectTransform>();
            rt.anchoredPosition = cardLocations[i];
            Card cardref = newCard.GetComponent<Card>();
            cardref.RandomlyDecideTrackType();
            cardref.SetTrackDescription(cardDescriptions[Random.Range(0, 3)]);
            cardref.SetTrackTitle(cardTitles[Random.Range(0, 3)]);
        }
    }
}
