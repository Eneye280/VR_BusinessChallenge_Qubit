using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPlayer : MonoBehaviour
{
    public void EnterTriggerHandInPlatform(Transform platform)
    {
        gameObject.transform.SetParent(platform);
    }
    public void ExitTriggerHandInPlatform()
    {
        gameObject.transform.parent = null;
    }
}
