using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePlant : MonoBehaviour
{
    public GameObject prefabe;
    public Transform Spawnpoint;

    void OnTriggerEnter()
    {
        Instantiate(prefabe, Spawnpoint.transform.position, Spawnpoint.transform.rotation);
    }
}
