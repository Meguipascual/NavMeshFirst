using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DetectionZoneScript : MonoBehaviour
{
    public NavMeshAgent enemy;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collides");
        Debug.Log("ccaacacaa");

        if (other.CompareTag("Agent"))
        {
            enemy.destination = transform.position;
        }
    }
}
