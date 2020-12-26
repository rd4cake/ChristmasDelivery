using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverySpotSpawner : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject[] mDeliveryPoints;

    [Header("Variables")]
    public Pickup mPickUp;
    [HideInInspector]
    public bool mIsPickedUp;
    private bool mSpawnDeliverPoint;
    private int mRandHouse;

    // Update is called once per frame
    void Update()
    {
        mIsPickedUp = mPickUp.mIsPickedUp;
        if (mIsPickedUp && !mSpawnDeliverPoint)
        {
            mRandHouse = Random.Range(0, mDeliveryPoints.Length);
            mSpawnDeliverPoint = true;
            mDeliveryPoints[mRandHouse].SetActive(true);
        }
        else if (!mIsPickedUp && mSpawnDeliverPoint)
        {
            mDeliveryPoints[mRandHouse].SetActive(false);
            mSpawnDeliverPoint = false;
        }
    }
}
