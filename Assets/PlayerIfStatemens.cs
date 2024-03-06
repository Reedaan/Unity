using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIfStatemens : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int _myScore;

    [SerializeField]
    private bool _hasMessageBeenSent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if we hit space key add 10 points
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _myScore += 10;
        }

        //if points are greater than or equal to 50
        //print out 
        if (_myScore >= 50 && _hasMessageBeenSent == false)
        {
            Debug.Log("You are awesome!");
            _hasMessageBeenSent = true;

        }

    }
}
