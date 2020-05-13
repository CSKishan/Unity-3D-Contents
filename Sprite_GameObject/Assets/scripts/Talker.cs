using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talker : MonoBehaviour
{
    // Makes the game element talk
    // Start is called before the first frame update
    void Start()
    {

        Vector3 position = transform.position;
        position.x = 1;
        //Say something 
        print("Im existing for a reason.");
    }

}
