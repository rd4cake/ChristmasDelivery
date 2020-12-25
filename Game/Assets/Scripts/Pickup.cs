using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform mHolder;

    GameObject mPresent;
    [HideInInspector]
    public bool mIsPickedUp;

    private void Update()
    {
        if (mIsPickedUp)
        {
            mPresent.transform.position = mHolder.position;
        }
        else
        {
            return;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Present") 
        { 
            mPresent = collision.gameObject;
            mIsPickedUp = true;
        }

    }
}
