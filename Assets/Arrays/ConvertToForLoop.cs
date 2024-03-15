using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToForLoop : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject[] cubes;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].GetComponent<Renderer>().material.color = Color.green;
            }
        }
    }
}
