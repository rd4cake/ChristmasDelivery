using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public float mMaxhealth=100;
    public float mEnemydamage=10;
    public GameObject mHealthbar;
    public float mDamagecooldown = 1;
    float mNextdamage = 0;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (mHealthbar.transform.localScale.x > 0 && Time.time> mNextdamage)
            {
                TakeDamage();
                mNextdamage = Time.time + mDamagecooldown;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            mHealthbar.transform.localScale = new Vector2(0, mHealthbar.transform.localScale.y);
        }
    }

    void TakeDamage()
    {
        float damage = mEnemydamage / mMaxhealth;
        mHealthbar.transform.localScale=new Vector2(mHealthbar.transform.localScale.x - damage, mHealthbar.transform.localScale.y);
    }
}
