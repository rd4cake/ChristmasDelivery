using UnityEngine;
using UnityEngine.UI;
public class Pickup : MonoBehaviour
{
    [Header("Game Objects")]
    public Transform mHolder;
    GameObject mPresent;
    public GameObject mDeliveredText;
    public AudioSource mPickUpSFX;
    public AudioSource mDeliveredSFX;

    [HideInInspector]
    public bool mIsPickedUp;
    [HideInInspector]
    public bool mDropOff;

    int score = 0;
    public Text mText;

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
            mPickUpSFX.Play();
            mPresent = collision.gameObject;
            mIsPickedUp = true;
        }

    }
    public void DropOff()
    {
        mDeliveredSFX.Play();
        LeanTween.scale(mDeliveredText, new Vector2(1,1), 1f);
        LeanTween.delayedCall(gameObject, 1f, () => {
            LeanTween.scale(mDeliveredText, new Vector2(0, 0), 1f);
        });
        score += 1;
        mText.text = score.ToString();
        Destroy(mPresent);
        mIsPickedUp = false;
    }
}
