using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentIndicator : MonoBehaviour
{
    GameObject target;
    public GameObject arrow;
    // Update is called once per frame

    private void Start()
    {
        arrow.SetActive(false);
    }
    void Update()
    {
        if (GameObject.FindWithTag("Present") != null)
        {
            arrow.SetActive(true);
            target = GameObject.FindWithTag("Present");
            var dir = target.transform.position - transform.position;
            var angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.up = dir;
        }
        else
        {
            arrow.SetActive(false);
        }
    }
}
