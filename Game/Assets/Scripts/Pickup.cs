using UnityEngine;

public class Pickup : MonoBehaviour
{
    [Header("Game Objects")]
    public Transform mHolder;
    GameObject mPresent;

    [HideInInspector]
    public bool mIsPickedUp;
    [HideInInspector]
    public bool mDropOff;

    private void Update()
    {
        if (mIsPickedUp)
        {
            mPresent.transform.position = mHolder.position;
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
    public void DropOff()
    {
        Destroy(mPresent);
        mIsPickedUp = false;
    }
}
