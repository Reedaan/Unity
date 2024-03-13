using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMessage : MonoBehaviour
{
    // Start is called before the first frame update
    public int points;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            points = 50;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            points = 100;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            points = 0;
        }

        switch (points)
        {
            case 50:
                Debug.Log("50 points!");
                break;
            case 100:
                Debug.Log("100 points!");
                break;
            default:
                Debug.Log("You need 50 or 100 points to receive a message!");
                break;
            
        }

    }   
}
