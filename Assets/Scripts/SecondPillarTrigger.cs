using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPillarTrigger : MonoBehaviour
{
    public GameObject Pillar2;
    public GameObject MovingPlatform001;

    void OnTriggerEnter(Collider other)
    {
        Pillar2.GetComponent<Animator>().Play("LeftPillars");
        MovingPlatform001.SetActive(true);
    }
}
