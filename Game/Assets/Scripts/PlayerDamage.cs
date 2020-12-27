using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    public Slider mHealthBar;
    private float mEnemydamage = 0.2f;
    private float mDamagecooldown = 1;
    private float mNextdamage = 0;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (mHealthBar.value > 0 && Time.time> mNextdamage)
            {
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
