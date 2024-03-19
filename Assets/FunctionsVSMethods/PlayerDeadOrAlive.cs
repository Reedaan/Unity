using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeadOrAlive : MonoBehaviour
{

    public bool IsPlayerAlive = true;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsPlayerAlive)
        {
            Damage(Random.Range(5, 10));
            Debug.Log("Damaged!");
        }
        
    }

    public void Damage(int DamageAmount)
    {
        health -= DamageAmount;

        if (health < 1)
        {
            health = 0;
            IsPlayerAlive = false;
            Debug.Log("You died!");
        }
    }

}
