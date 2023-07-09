using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeLerp_TMPro : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI fadeText;
    [SerializeField] private float fadeSpeed = 1;

    private Color oColor, nColor;

    private void Awake()
    {        
        oColor = fadeText.color; // the alpha here is 0
        nColor = fadeText.color;
        nColor.a = 255f;
    }
    private void Update()
    {

        fadeText.color =  new Color(fadeText.color.r, fadeText.color.g, fadeText.color.b, Mathf.PingPong(Time.time * fadeSpeed, 1));
    }
}
