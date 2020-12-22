using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyrotation : MonoBehaviour
{
    public Transform mTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    void Rotation()
    {
        Vector2 position = mTarget.position - transform.position;
        transform.up = position;
    }
}
