using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform mHolder;
    bool pickup = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject present = GameObject.FindWithTag("Present");
        if (pickup==true)
        {
            present.transform.position = mHolder.position;
            Debug.Log(pickup);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Present")
        {
            pickup = true;
        }

    }
}
