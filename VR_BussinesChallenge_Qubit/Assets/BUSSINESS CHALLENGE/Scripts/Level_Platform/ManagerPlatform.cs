using System;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPlatform : MonoBehaviour
{
    [SerializeField] internal GameObject contentPlatform;
    public List<GameObject> listPlatform;
    [SerializeField] internal int leghtList;

    private void Start()
    {
        for (int i = 0; i < leghtList; i++)
        {
            listPlatform.Add(contentPlatform.transform.GetChild(i).gameObject); 
        }
    }
}

public static class ManagerEvents
{
    public static Action<bool> isVerifyOnOffPlatform;
}
