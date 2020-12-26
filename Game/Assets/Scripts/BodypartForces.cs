using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodypartForces : MonoBehaviour
{
    Rigidbody2D mRigidbody;
    float x;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        mRigidbody = GetComponent<Rigidbody2D>();
        x = Random.Range(-5, 5);
        y = Random.Range(-5, 5);
        mRigidbody.velocity = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
