using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PerseguirPlayer : MonoBehaviour
{
   

    public Transform jogador1; // Refer�ncia ao jogador 1
    public Transform jogador2; // Refer�ncia ao jogador 2
    public NavMeshAgent agente; // O NavMeshAgent do inimigo

   


void Start()
    {
      
  
    }

    void Update()
    {
        float distanciaJogador1 = Vector3.Distance(transform.position, jogador1.position);
    float distanciaJogador2 = Vector3.Distance(transform.position, jogador2.position);
    
    Transform jogadorMaisProximo;
    if (distanciaJogador1 < distanciaJogador2)
    {
        jogadorMaisProximo = jogador1;
    }
    else
    {
        jogadorMaisProximo = jogador2;
    }

    
    agente.SetDestination(jogadorMaisProximo.position);



    }
}
