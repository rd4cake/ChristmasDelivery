using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyrotation : MonoBehaviour
{
    GameObject mTarget;
    // Start is called before the first frame update
    void Start()
    {
        mTarget = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    void Rotation()
    {
        Vector2 position = mTarget.transform.position - transform.position;
        transform.up = position;
    }
}
