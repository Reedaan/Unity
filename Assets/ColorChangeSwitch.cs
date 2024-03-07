using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeSwitch : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;
    public int currentColorNumber;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentColorNumber = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentColorNumber = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentColorNumber = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentColorNumber = 3;
        }

        switch (currentColorNumber)
        {
            case 0:
                cube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 1:
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                cube.GetComponent<Renderer>().material.color = Color.black;
                break;

        }
    }
}
