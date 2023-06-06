using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Takip edilecek hedefin referansý
    public float followSpeed = 2f; // Kamera takip hýzý

    private CinemachineVirtualCamera virtualCamera; // Cinemachine sanal kamera bileþeni

    private void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void Update()
    {
        if (target != null)
        {
            // Hedefin pozisyonunu kameranýn takip etmesini saðla
            transform.position = Vector3.Lerp(transform.position, target.position, followSpeed * Time.deltaTime);

            // Cinemachine sanal kamera hedefini ayarla
            virtualCamera.Follow = target;
        }
    }
}
