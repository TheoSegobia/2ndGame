using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPillarTrigger : MonoBehaviour
{
    public GameObject Pillar1;
    public GameObject Dock;

    void OnTriggerEnter(Collider other)
    {
        Pillar1.GetComponent<Animator>().Play("RightPillars");
        Dock.GetComponent<Animator>().Play("DockUp");
    }
}
