using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverySpot : MonoBehaviour
{
    public GameObject[] mDeliveryPoints;
    private bool mIsPickedUp;
    private bool mSpawnDeliverPoint;

    public Pickup mPickUp;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mIsPickedUp = mPickUp.mIsPickedUp;
        if (mIsPickedUp && !mSpawnDeliverPoint)
        {
            int randHouse = Random.Range(0, mDeliveryPoints.Length);
            mSpawnDeliverPoint = true;
            mDeliveryPoints[randHouse].SetActive(true);
        }
    }
}
