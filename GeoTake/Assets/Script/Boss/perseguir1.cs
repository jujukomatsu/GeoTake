using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class perseguir1 : MonoBehaviour
{
  public Transform jogador1; // Refer�ncia ao jogador 1
   
    public NavMeshAgent agente; // O NavMeshAgent do inimigo

   


void Start()
    {
      
  
    }

    void Update()
    {
    
   
     agente.SetDestination(jogador1.position);



    }
}
