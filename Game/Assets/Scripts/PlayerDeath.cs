using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject[] mBodyparts;
    public GameObject Blood;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Car")
        {
            Destroy(gameObject);
            Spawnparts();
            Instantiate(Blood, transform.position, Quaternion.identity);
        }
    }

    void Spawnparts()
    {
        for (int i = 0; i < mBodyparts.Length; i++)
        {
            Instantiate(mBodyparts[i], transform.position, Quaternion.identity);
        }
    }
}
