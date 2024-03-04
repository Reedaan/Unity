using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    // Start is called before the first frame update

    //bill is 40
    //tip is 20% or based on what the user wants
    //calculate the total ammount

    public float bill = 40;
    public float tipPercentage = 20;
    public float totalAmount = 0;

    void Start()
    {
        float tipValue = bill * (tipPercentage / 100);
        totalAmount = bill + tipValue;
        Debug.Log("Your bill is: " + bill + "and your tip amount is: " + tipValue + "so you owe: " + totalAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
