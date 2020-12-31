using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] mEnemy;
    public GameObject mPlayer;
    GameObject mPresentcheck;
    public Collider2D[] mColliders;
    public LayerMask mMask;
    bool condition = false;
    GameObject nNewEnemy;
    public float mSpawntime=5f;

    private void Start()
    {
        InvokeRepeating("Spawn", 5f, mSpawntime);
    }
    void Spawn()
    {
        condition = false;
        while (condition == false)
        {

            Vector3 Newpos = new Vector3(Random.Range(-13f, 103f), Random.Range(28f, -60f), 0);
            mColliders = Physics2D.OverlapCircleAll(Newpos, 3, mMask);
            if (mColliders.Length == 0 && (transform.position - mPlayer.transform.position).magnitude > 20)
            {
                int type = Random.Range(0, 2);
                GameObject nNewEnemy=Instantiate(mEnemy[type], Newpos, Quaternion.identity);
                var Enemyspeed = nNewEnemy.GetComponent<AIPath>();
                float speed= Random.Range(10.0f, 15.0f);
                Enemyspeed.maxSpeed = speed;
                condition = true;
            }
        }
    }
}
