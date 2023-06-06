using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvScript : MonoBehaviour
{
    public GameObject lightObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lightObject.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lightObject.SetActive(true);
        }
    }
}
