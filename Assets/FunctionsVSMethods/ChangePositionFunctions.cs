using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePositionFunctions : MonoBehaviour
{
    //Create an array of 5 different positions and use a custom method to generate a random index, and then use a custom
    //method to set the position to that sub index
    public Vector3[] positions;
    private int _randomIndex;

    
    void Start()
    {
        transform.position = GetRandomPosition(GetRandomIndex());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GetRandomIndex()
    {
        return Random.Range(0, positions.Length);
    }

    Vector3 GetRandomPosition(int index)
    {
        return positions[index];
    }


}
