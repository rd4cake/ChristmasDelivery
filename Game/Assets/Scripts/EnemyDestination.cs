using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnemyDestination : MonoBehaviour
{
    GameObject mPlayer;
    // Start is called before the first frame update
    void Start()
    {
        var mAIDestinationSetter = GetComponent<AIDestinationSetter>();
        mPlayer = GameObject.FindWithTag("Player");
        mAIDestinationSetter.target = mPlayer.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
