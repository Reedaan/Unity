using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{

    // Start is called before the first frame update
    //Create a program that lets you increment the speed when you hit the W key
    //S key decrements the speed
    //when the speed is greater than 20 you need to print Slow Down
    //when the speed is 0 print out speed up
    //You cant go below 0

    [SerializeField]
    private int _speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _speed += 5;
        }
        else if (Input.GetKeyDown(KeyCode.S) && _speed > 0)
        {
            _speed -= 5;
        }

        if (_speed > 20)
        {
            Debug.Log("Slow Down!");
        }
        else if (_speed == 0)
        {
            Debug.Log("Speed up!");
        }
    }
}
