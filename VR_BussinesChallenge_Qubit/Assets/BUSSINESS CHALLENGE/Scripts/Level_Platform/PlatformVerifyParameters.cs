using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformVerifyParameters : MonoBehaviour
{
    [SerializeField] internal Platform platform;

    private void Start()
    {
        platform = transform.parent.GetComponent<Platform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && platform.isEnablePlatform)
        {
            transform.parent.gameObject.SetActive(true);
            platform.textNamePlatform.enabled = false;
        }
        if (other.CompareTag("Player") && !platform.isEnablePlatform)
        {
            transform.parent.gameObject.SetActive(false);
            other.gameObject.AddComponent<Rigidbody>();
        }
    }
}
