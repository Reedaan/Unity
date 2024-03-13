using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeCalculator : MonoBehaviour
{
    // Start is called before the first frame update

    public float grade1, grade2, grade3, grade4, grade5;
    public float averageGrade;
    private bool _hasMessageBeenSent;

    void Start()
    {
        grade1 = Random.Range(1, 101);
        grade2 = Random.Range(1, 101);
        grade3 = Random.Range(1, 101);
        grade4 = Random.Range(1, 101);
        grade5 = Random.Range(1, 101);

        averageGrade = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;

        if (averageGrade >= 90 && _hasMessageBeenSent == false)
        {
            Debug.Log("You got an A!");
        }
        else if (averageGrade >= 80)
        {
            Debug.Log("You got a B!");
        }
        else if (averageGrade >= 70)
        {
            Debug.Log("You got a C!");
        }
        else
        {
            Debug.Log("You got an F!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
            
        
    }
}
