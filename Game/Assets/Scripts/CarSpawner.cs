using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject car;
    public float speed;
    GameObject newCar;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateCar", 2.0f, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D CarRigidBody = newCar.GetComponent<Rigidbody2D>();
        CarRigidBody.velocity = new Vector2(speed, 0);
    }

    void CreateCar()
    {
        newCar=Instantiate(car, transform.position, Quaternion.identity);
        Rigidbody2D CarRigidBody = newCar.GetComponent<Rigidbody2D>();
        CarRigidBody.AddForce(transform.right*speed);
    }
}
