using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGain : MonoBehaviour
{
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
<<<<<<< HEAD
            AudioManager.PlayAudioFile(4);
            mPlayerDamage.mHealthBar.value += mAmountgain;
=======
            mPlayerDamage.mHealthBar.value = 1;
>>>>>>> 0deda09cd74f98cf6b76006ace8972100a7c3077
            Destroy(gameObject);
        }
    }
}
