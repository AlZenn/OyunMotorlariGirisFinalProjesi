using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public GameObject playerObject, talkSound;
    public Animator npcAnimator;
    public float talkDistance = 3f;

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, playerObject.transform.position);

        if (distance <= talkDistance)
        {
            talkSound.SetActive(true);
            npcAnimator.SetBool("Talking", true);
        }
        else
        {
            talkSound.SetActive(false);
            npcAnimator.SetBool("Talking", false);
            
        }
    }
}
