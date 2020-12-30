using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    public Slider mHealthBar;
    public AudioSource mOnHitSFX;
    private float mEnemydamage = 0.201f;
    private float mDamagecooldown = 0.5f;
    private float mNextdamage = 0;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (mHealthBar .value > 0 && Time.time> mNextdamage)
            {
                AudioManager.PlayAudioFile(0);
                mHealthBar.value -= mEnemydamage;
                mNextdamage = Time.time + mDamagecooldown;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            mHealthBar.value = 0;
        }
    }
}
