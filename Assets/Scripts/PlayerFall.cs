using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{
    public Transform teleport;
    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        Player.transform.position=teleport.transform.position;
    }
}
