using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;

        //resizing
        newScale.x *= 4;
        newScale.y *= 4;
        //attaching back to actual size

        transform.localScale = newScale;

        print("Yellow teddy bear resized");
        
    }

}
