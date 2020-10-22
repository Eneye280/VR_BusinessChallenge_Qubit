using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] internal bool isEnablePlatform;

    [Space(15)]
    [SerializeField] internal string namePlatform;
    [SerializeField] internal TextMeshPro textNamePlatform;

    private void Start()
    {
        textNamePlatform = transform.GetChild(0).GetComponent<TextMeshPro>();
        textNamePlatform.text = namePlatform;
        textNamePlatform.enabled = false;
        ManagerEvents.isVerifyOnOffPlatform += EnablePlayerInPlatform;
    }

    private void EnablePlayerInPlatform(bool isEnable)
    {
        isEnable = isEnablePlatform;

        if (isEnablePlatform)
        {
            print("EL JUGADOR SIGUE VIVO");
        }

        if(!isEnablePlatform)
        {
            print("EL JUGADOR MUERE");
        }
    }

    public void CallEvent()
    {
        ManagerEvents.isVerifyOnOffPlatform(true);
    }
}
