using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{
    public GameObject Portal;

    void OnTriggerEnter(Collider other)
    {
        Portal.GetComponent<Animator>().Play("PortalOpen");
    }
}
