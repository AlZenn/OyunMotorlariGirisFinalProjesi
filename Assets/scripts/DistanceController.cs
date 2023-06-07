using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceController : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject npcObject;
    public Text distanceText;
    private void Update()
    {
        float distance = Vector3.Distance(playerObject.transform.position, npcObject.transform.position);
        distanceText.text = "Distance: " + distance.ToString("F2") + "m";
    }
}
