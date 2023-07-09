using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickMonitoring : MonoBehaviour, IPointerClickHandler
{
    public GameObject cardGeneratorRef;
    public CardGenerator cardGenerator;
    public GameObject cardSFXManagerRef;
    public CardSFXManager cardSFXManager;

    // Start is called before the first frame update
    void Start()
    {
        cardGeneratorRef = GameObject.FindGameObjectWithTag("Card Generator");
        cardGenerator = cardGeneratorRef.GetComponent<CardGenerator>();
        cardSFXManagerRef = GameObject.FindGameObjectWithTag("Card SFX Manager");
        cardSFXManager = cardSFXManagerRef.GetComponent<CardSFXManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Left click - Card Played");
            cardSFXManager.PlayCardSelectSFX();
            Destroy(gameObject.transform.parent.gameObject);
            cardGenerator.cardsPlayed++;
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (cardGenerator.cardsDiscarded == 2)
            {
                Debug.Log("You've already discarded two cards!");
            }
            else
            {
                Debug.Log("Right click - Card Discarded");
                cardSFXManager.PlayCardDiscardSFX();
                Destroy(gameObject.transform.parent.gameObject);
                cardGenerator.cardsDiscarded++;
            }
        }
    }
}
