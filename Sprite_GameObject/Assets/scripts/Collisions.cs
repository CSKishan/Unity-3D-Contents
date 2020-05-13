using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Moving the object to the right
        /*Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(2, 2),
            ForceMode2D.Impulse);*/

        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = UnityEngine.Random.Range(0, (float)(2 * Math.PI));
        UnityEngine.Vector2 direction = new UnityEngine.Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = UnityEngine.Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction*magnitude, 
            ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        print("Bounce " + i + " !");
        i++;
    }

}
