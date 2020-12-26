using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentIndicator : MonoBehaviour
{
    [Header("Game Objects")]
    GameObject target;
    public GameObject arrow;
    private Pickup mPickUp;

    private void Start()
    {
        mPickUp = GetComponentInParent<Pickup>();
        Debug.Log(mPickUp);
    }
    void Update()
    {
        if (mPickUp.mIsPickedUp)
        {
            target = GameObject.FindWithTag("DeliverySpot");
            Debug.Log(target.transform.position);
            var dir = target.transform.position - transform.position;
            var angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.up = dir;
        }
        else if (GameObject.FindWithTag("Present") != null)
        {
            target = GameObject.FindWithTag("Present");
            var dir = target.transform.position - transform.position;
            var angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.up = dir;
        }

    }
}
