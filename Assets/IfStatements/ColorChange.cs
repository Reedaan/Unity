using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int score;
    public GameObject cube;

    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
        }

        if (score >= 50)
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
