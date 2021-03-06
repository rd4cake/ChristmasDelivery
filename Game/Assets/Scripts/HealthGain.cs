using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGain : MonoBehaviour
{
    public PlayerDamage mPlayerDamage;

    void Start()
    {
        mPlayerDamage=GameObject.Find("Santa").GetComponent<PlayerDamage>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioManager.PlayAudioFile(4);
            mPlayerDamage.mHealthBar.value = 1;
            Destroy(gameObject);
        }
    }
}
