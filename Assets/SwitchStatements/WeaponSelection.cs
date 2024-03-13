using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelection : MonoBehaviour
{
    // Start is called before the first frame update
    public int weaponID;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponID = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponID = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weaponID = 3;
        }

        switch (weaponID)
        {
            case 1:
                Debug.Log("You are currently holding a gun");
                break;
            case 2:
                Debug.Log("You are currently holding a knife");
                break;
            case 3:
                Debug.Log("You are currently holding a machine gun");
                break;
            default:
                Debug.Log("Invalid weapon");
                break;
        }

    }
}
