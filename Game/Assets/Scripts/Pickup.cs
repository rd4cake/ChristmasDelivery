using UnityEngine;

public class Pickup : MonoBehaviour
{
    [Header("Game Objects")]
    public Transform mHolder;
    GameObject mPresent;
    public GameObject mDeliveredText;

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
        LeanTween.scale(mDeliveredText, new Vector2(1,1), 1f);
        LeanTween.delayedCall(gameObject, 1f, () => {
            LeanTween.scale(mDeliveredText, new Vector2(0, 0), 1f);
        });
        Destroy(mPresent);
        mIsPickedUp = false;
    }
}
