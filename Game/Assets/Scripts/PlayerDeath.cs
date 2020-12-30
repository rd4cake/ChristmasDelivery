using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject[] mBodyparts;
    public GameObject Blood;
    private GameObject mAudioManager;
    public GameObject mGameOverPanel;
    public PlayerDamage mPlayerDamage;
    private void Start()
    {
       mAudioManager = GameObject.Find("AudioManager");
    }

    private void Update()
    {
        if(GameObject.Find("Santa")==null)
        {
            Destroy(gameObject);
        }

        if(gameObject.tag=="Player")
        {
            if(mPlayerDamage.mHealthBar.value <=0)
            {
                Spawnparts();
                gameObject.SetActive(false);
                GameObject nNewblood = Instantiate(Blood, transform.position, Quaternion.identity);
                Destroy(nNewblood, 2f);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Car")
        {
            AudioManager.PlayAudioFile(0);
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
        if (gameObject.tag == "Player")
        {
            AudioManager.PlayAudioFile(1);
            LeanTween.delayedCall(gameObject, 1.2f, () =>
            {
                LeanTween.scale(mGameOverPanel, new Vector2(1f, 1f), 1.2f);
            });
        }

    }

}
