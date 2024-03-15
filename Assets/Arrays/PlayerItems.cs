using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Items
{
    public int itemID;
    public string itemName;
    public string itemDescription;
}

public class PlayerItems : MonoBehaviour
{
    

    public Items[] myItems;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in myItems)
        {
            if (item.itemID == 7)
            {
                Debug.Log("You have it!");
            }
            else
            {
                Debug.Log("You dont have the item!");
            }
        }

        for (int i = 0; i < myItems.Length; i++)
        {
            if (myItems[i].itemID == 7)
            {
                Debug.Log("You have it!");
            }
            else
            {
                Debug.Log("You don't have the item!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomNumber = Random.Range(0, myItems.Length);
            Debug.Log(myItems[randomNumber].itemName);
        }

        
    }
}
