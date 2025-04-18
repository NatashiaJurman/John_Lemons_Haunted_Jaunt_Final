using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ReaperChase : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform Player;

    int m_CurrentWaypointIndex;

    void Update()
    {
        navMeshAgent.SetDestination(Player.position);
    }

   
}
