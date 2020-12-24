using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presentspawn : MonoBehaviour
{
    public GameObject mPresent;
    GameObject mPresentcheck;
    public Collider2D[] mColliders;
    public LayerMask mMask;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Newpos = new Vector3(Random.Range(-8f, 105f), Random.Range(19f, -70f), 0);
        mPresentcheck = GameObject.FindWithTag("Present");
        mColliders = Physics2D.OverlapCircleAll(Newpos, 3, mMask);
        if (mPresentcheck == null && mColliders.Length==0)
        {
            Instantiate(mPresent, Newpos, Quaternion.identity);
        }
    }
}
