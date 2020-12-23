using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlapcheck : MonoBehaviour
{
    public LayerMask mMask;
    public Collider2D[] colliders;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        colliders = Physics2D.OverlapCircleAll(transform.position, 3, mMask);

    }
}
