using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentSpawn : MonoBehaviour
{
    public GameObject [] mPresent;
    public GameObject mPlayer;
    GameObject mPresentcheck;
    [HideInInspector]
    public Collider2D[] mColliders;
    public LayerMask mMask;

    void Update()
    {
        Vector3 Newpos = new Vector3(Random.Range(-13f, 103f), Random.Range(28f, -60f), 0);
        mPresentcheck = GameObject.FindWithTag("Present");
        mColliders = Physics2D.OverlapCircleAll(Newpos, 3, mMask);
        if (mPresentcheck == null && mColliders.Length == 0 && (transform.position-mPlayer.transform.position).magnitude>10)
        {
            int randGift = Random.Range(0, mPresent.Length - 1);
            Instantiate(mPresent[randGift], Newpos, Quaternion.identity);
        }
    }
}
