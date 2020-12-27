using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repulsion : MonoBehaviour
{
    Rigidbody2D mRigidbody2D;
    public float force=2;
    // Start is called before the first frame update
    void Start()
    {
        mRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Vector2 dir = collision.transform.position- transform.position;
            dir = -dir.normalized;
            mRigidbody2D.AddForce(dir * force);
            Debug.Log("repulsion added");
        }
    }
}
