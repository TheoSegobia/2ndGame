using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger001 : MonoBehaviour
{
    public GameObject Platform2;

    void OnTriggerEnter(Collider other)
    {
        Platform2.GetComponent<Animator>().Play("MovingPlatform8");
    }
}
