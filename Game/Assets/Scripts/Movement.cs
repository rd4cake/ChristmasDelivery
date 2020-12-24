using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Variables")]
    public float mMoveSpeed = 51f;
    Vector2 mMovement;

    [Header("Components")]
    public Transform mTransform;
    public Rigidbody2D mRigidbody;

    void Start()
    {
        mRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        mMovement.x = Input.GetAxisRaw("Horizontal");
        mMovement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        mRigidbody.velocity = new Vector2(mMovement.x*mMoveSpeed,mMovement.y*mMoveSpeed);
        //transform.Translate(mMovement * mMoveSpeed * Time.deltaTime, Space.World);
        transform.up = -mRigidbody.velocity.normalized;
    }
}
