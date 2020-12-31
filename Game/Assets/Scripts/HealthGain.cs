using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGain : MonoBehaviour
{
    private float mAmountgain = 0.201f;
    public PlayerDamage mPlayerDamage;
    // Start is called before the first frame update
    void Start()
    {
        mPlayerDamage=GameObject.Find("Santa").GetComponent<PlayerDamage>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioManager.PlayAudioFile(4);
            mPlayerDamage.mHealthBar.value += mAmountgain;
            Destroy(gameObject);
        }
    }
}
