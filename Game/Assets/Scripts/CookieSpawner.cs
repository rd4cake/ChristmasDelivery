using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieSpawner : MonoBehaviour
{
    public GameObject mCookie;
    public GameObject mPlayer;
    public Collider2D[] mColliders;
    public LayerMask mMask;
    GameObject[] mCookiecount;

    private void Start()
    {
        InvokeRepeating("spawntime", 5f, 8f);
    }
    void spawntime()
    {
        bool condition = false;
        while (condition == false)
        {
            mCookiecount = GameObject.FindGameObjectsWithTag("Cookie");
            Debug.Log(mCookiecount);
            int mCookieamount = mCookiecount.Length;
            Vector3 Newpos = new Vector3(Random.Range(-13f, 103f), Random.Range(28f, -60f), 0);

            mColliders = Physics2D.OverlapCircleAll(Newpos, 3, mMask);
            if (mCookieamount <= 3 && mColliders.Length == 0 && (transform.position - mPlayer.transform.position).magnitude > 20)
            {
                Instantiate(mCookie, Newpos, Quaternion.identity);
                Debug.Log(Newpos);
                Debug.Log (mCookie.transform.position);
            }
            condition = true;
        }
    }
}
