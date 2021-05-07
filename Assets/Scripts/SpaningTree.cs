using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaningTree : MonoBehaviour
{
    public GameObject planttoCreate;
    void OnCollisionEnter()
    {
        Instantiate(planttoCreate, transform.position, transform.rotation);
    }
}
