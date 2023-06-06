using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public GameObject playerObject;
    public Animator npcAnimator;
    public float talkDistance = 3f;
    public AudioSource talkSound;

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, playerObject.transform.position);

        if (distance <= talkDistance)
        {
            
            npcAnimator.SetBool("Talking", true);
            
        }
        else
        {
            talkSound.Play();
            
            npcAnimator.SetBool("Talking", false);
            
        }
    }
}
