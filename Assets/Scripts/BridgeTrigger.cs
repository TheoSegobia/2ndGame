using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTrigger : MonoBehaviour
{
    public GameObject theBridge;

    void OnTriggerEnter(Collider other)
    {
        theBridge.GetComponent<Animator>().Play("BridgeUp");
    }
}
