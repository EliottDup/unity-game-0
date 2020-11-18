using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform spawnpoint;
    public GameObject player;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = spawnpoint.transform.position;
    }
}
