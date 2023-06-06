using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Takip edilecek hedefin referans�
    public float followSpeed = 2f; // Kamera takip h�z�

    private CinemachineVirtualCamera virtualCamera; // Cinemachine sanal kamera bile�eni

    private void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void Update()
    {
        if (target != null)
        {
            // Hedefin pozisyonunu kameran�n takip etmesini sa�la
            transform.position = Vector3.Lerp(transform.position, target.position, followSpeed * Time.deltaTime);

            // Cinemachine sanal kamera hedefini ayarla
            virtualCamera.Follow = target;
        }
    }
}
