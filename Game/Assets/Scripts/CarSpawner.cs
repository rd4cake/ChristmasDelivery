using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [Header("Objects")]
    public GameObject mCar;

    [Header ("Variables")]
    public Quaternion mRotation;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateCar", 2.0f, 7f);
    }

    void CreateCar()
    {
        Instantiate(mCar, transform.position, mRotation);
    }
}
