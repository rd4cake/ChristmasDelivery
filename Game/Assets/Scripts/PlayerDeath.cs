using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject[] mBodyparts;
    public GameObject Blood;
    private GameObject mAudioManager;

    private void Start()
    {
        mAudioManager = GameObject.Find("AudioManager");
        Debug.Log(mAudioManager);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Car")
        {
            mAudioManager.GetComponent<AudioSource>().Play();
            if (gameObject.tag=="Player")
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }

            Spawnparts();
            GameObject nNewblood = Instantiate(Blood, transform.position, Quaternion.identity);
            Destroy(nNewblood, 2f);
        }
    }

    void Spawnparts()
    {
        for (int i = 0; i < mBodyparts.Length; i++)
        {
            GameObject nNewbodyparts = Instantiate(mBodyparts[i], transform.position, Quaternion.identity);
            Destroy(nNewbodyparts, 2f);
        }
    }

}
