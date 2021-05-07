using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 13)
        {
            plantCollector plantcollector = GetComponent<plantCollector>();
            plantcollector.scoreOfGame += 5;
            Destroy(other.gameObject);
        }
    }

}
