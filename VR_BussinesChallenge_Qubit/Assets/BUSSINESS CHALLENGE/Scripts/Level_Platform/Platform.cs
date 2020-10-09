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

    [Space(15)]
    [SerializeField] internal GameObject childEmissionPlatform;

    private void Start()
    {
        textNamePlatform = transform.GetChild(1).GetComponent<TextMeshPro>();
        textNamePlatform.text = namePlatform;
        textNamePlatform.enabled = false;

        childEmissionPlatform = transform.GetChild(2).gameObject;
        childEmissionPlatform.SetActive(false);

        ManagerEvents.isVerifyOnOffPlatform += EnablePlayerInPlatform;
    }
    //private void OnEnable()
    //{
    //    ManagerEvents.isVerifyOnOffPlatform += EnablePlayerInPlatform;
    //}

    public void EnablePlayerInPlatform(bool isEnable)
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


    //private void OnDisable() => ManagerEvents.isVerifyOnOffPlatform -= EnablePlayerInPlatform;
}
