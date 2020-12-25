using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCar : MonoBehaviour
{
    Rigidbody2D mRigidbody;

    public Vector2 mMovement;

    private void Start()
    {
        mRigidbody = GetComponent<Rigidbody2D>();

        //Car destroys itself after 8 seconds
        LeanTween.delayedCall(gameObject, 4f, () => {
            Destroy(gameObject);
        });
    }

    private void FixedUpdate()
    {
        mRigidbody.velocity = mMovement;
    }
}
