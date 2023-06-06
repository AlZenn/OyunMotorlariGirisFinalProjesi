using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheremovement : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Hareket etmek için rastgele bir kuvvet uygula
            Vector3 force = new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f));
            rb.AddForce(force, ForceMode.Impulse);
        }
    }
}
