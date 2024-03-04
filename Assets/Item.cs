using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    // Every item has a name
    public string itemName = "Headhunter";
    //Every item has a description
    public string itemDescription = "A man's soul rules from a cavern of bone, learns and judges through flesh-born windows.The heart is meat. The head is where the Man is.";
    //Every item has an image icon
    public Sprite itemIcon;
    //Every item has an attack strength
    public int itemStrength = 10;
    void Start()
    {
        Debug.Log("The item name is: " + itemName);
        Debug.Log("Item description: " + itemDescription);
        Debug.Log("Item strength: " + itemStrength);
    }
}
