using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionColorChange : MonoBehaviour
{

    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(cube, Color.blue);
        }
       
    }

    public void ChangeColor(GameObject obj, Color ColorToAssign)
    {
        obj.GetComponent<Renderer>().material.color = ColorToAssign;
    }
}
