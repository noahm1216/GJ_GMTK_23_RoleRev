using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_OnHover_Racers : MonoBehaviour
{
    //the gameobject prefab we're referenceing
    public GameObject myRacer;
    //the script it holds
    public RaceCarBehavior myCarScript;

    //the UI for each stats
    public Image sliderImage;

    public void OnPointerEnter(PointerEventData eventData)
    {       
        
    }//end of OnPointerEnter()

    public void OnPointerExit(PointerEventData eventData)
    {
       
    }//end of OnPointerExit   

}
