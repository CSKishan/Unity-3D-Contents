using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Make 3 times wider
        Vector3 newScale = transform.localScale;

        newScale.x *= 3;
        transform.localScale = newScale;

        // made 3 times wider
        print("Teddy bear is 3 times wider");
    }

}
