﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Make green teddy bear taller

        Vector3 newScale = transform.localScale;
        //make it taller (increase y coordinates)

        newScale.y *= 3;
        transform.localScale = newScale;
        print("Green teddy bear is taller");

    }

}
