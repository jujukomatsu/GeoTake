using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataques : MonoBehaviour
{
    public GameObject obs;
       private int contador;
           void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        contador += Mathf.CeilToInt(Time.deltaTime );
        
        if(contador ==300){
               Debug.Log("Terreno Ativado");

               
                 obs.SetActive(true);
               
            
           
        }
        if(contador ==600){
               Debug.Log("Terreno Desativado");
            
                 obs.SetActive(false);
               
        
        }
        if(contador ==900){
               Debug.Log("Terreno Ativado");
            
                 obs.SetActive(true);
               
           
        }
            if(contador ==1200){
                Debug.Log("Terreno Desativado");
           
                 obs.SetActive(false);
               
                contador = 0;
                Time.timeScale = 1;
        }
    }
}
