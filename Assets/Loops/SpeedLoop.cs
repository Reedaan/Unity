using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLoop : MonoBehaviour
{
    // Start is called before the first frame update

    //Create a program where you increment the value of speed by 5 every second -- when speed is greater 
    //than MaxSpeed, stop incrementing (Random between 60 and 120)
    //Hint use coroutine

    public int speed;
    public int MaxSpeed;

    void Start()
    {
        MaxSpeed = Random.Range(60, 100);

        StartCoroutine(SpeedAccelerate());
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    IEnumerator SpeedAccelerate()
    {
        while (speed + 5 < MaxSpeed)
        {
            speed += 5;
            yield return new WaitForSeconds(1.0f);
        }
        
    }
}
