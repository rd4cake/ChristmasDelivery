using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Variables")]
    private float mMoveSpeed = 7f;
    Vector2 mMovement;

    [Header("Components")]
    public Transform mTransform;
    public Rigidbody2D mRigidbody;

    void Update()
    {
        mMovement.x = Input.GetAxisRaw("Horizontal");
        mMovement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        mRigidbody.velocity = mMovement * mMoveSpeed;
        //transform.Translate(mMovement * mMoveSpeed * Time.deltaTime, Space.World);
        transform.up = -mRigidbody.velocity.normalized;
    }
}
