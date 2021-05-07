using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingDestroyed : MonoBehaviour
{
    public int myPoints = 0;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 13)
        {
            myPoints = myPoints + 5;
            Destroy(other.gameObject);

        }
    }
}
