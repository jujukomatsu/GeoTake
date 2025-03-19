using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PerseguirPlayer : MonoBehaviour
{
    private NavMeshAgent inimigo;
    public Transform player;



    void Start()
    {
        inimigo = GetComponent<NavMeshAgent>();
  
    }

    // Update is called once per frame
    void Update()
    {
        inimigo = GetComponent<NavMeshAgent>();
        inimigo.destination = player.position;
    }
}
