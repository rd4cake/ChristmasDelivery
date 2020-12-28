using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] mEnemy;
    public GameObject mPlayer;
    GameObject mPresentcheck;
    public Collider2D[] mColliders;
    public LayerMask mMask;
    bool condition = false;

    private void Start()
    {
        InvokeRepeating("Spawn", 1f, 1f);
    }
    void Spawn()
    {
        condition = false;
        while (condition == false)
        {
            Vector3 Newpos = new Vector3(Random.Range(-13f, 103f), Random.Range(28f, -60f), 0);
            mColliders = Physics2D.OverlapCircleAll(Newpos, 3, mMask);
            int type = Random.Range(0, 2);
            if (mColliders.Length == 0 && (transform.position - mPlayer.transform.position).magnitude > 10)
            {
                Instantiate(mEnemy[type], Newpos, Quaternion.identity);
                condition = true;
            }
        }
    }
}
