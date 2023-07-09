using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTileMatSwapper : MonoBehaviour
{
    [SerializeField] private List<Material> hexMatOptions = new List<Material>();
    private bool hasGenColors;

    // Start is called before the first frame update
    void Update() // change to onEnable for testing
    {
        if (!hasGenColors)
        {
            print("hex mats gen colors");
            foreach (Transform _child in transform)
            {
                if (_child.GetComponent<Renderer>() != null && _child.name !=("GhostHex"))
                {
                    int randomRange = Random.Range(0, hexMatOptions.Count);
                    _child.GetComponent<Renderer>().sharedMaterial = hexMatOptions[randomRange];
                }
            }
            hasGenColors = true;
        }
    }


}
