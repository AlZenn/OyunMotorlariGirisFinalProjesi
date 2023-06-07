using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 2f;
    public float distanceFromTarget = 3f;
    public float heightOffset = 5f;
    private CinemachineVirtualCamera virtualCamera;
    private void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        virtualCamera.m_Lens.Orthographic = false;
    }

void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position - target.forward * distanceFromTarget + Vector3.up * heightOffset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(50f, target.eulerAngles.y, 0f);
            virtualCamera.Follow = target;
        }
    }


}