using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataques : MonoBehaviour
{
    public GameObject obs2;
    public GameObject obs;
    public GameObject movim1;
    public GameObject movim2;
       private int contador;
           void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        contador += Mathf.CeilToInt(Time.deltaTime * 1);
        Debug.Log(contador);
        if(contador ==1500){
               Debug.Log("Terreno Ativado");

               
                 obs.SetActive(true);
               
            
           
        }
        if(contador ==3000){
               Debug.Log("Terreno Desativado");
            
                 obs.SetActive(false);
               
        
        }
        if(contador ==4500){
               Debug.Log("Terreno Ativado");
            
                 obs2.SetActive(true);
               
           
        }
            if(contador ==6000){
                Debug.Log("Terreno Desativado");
           
                 obs2.SetActive(false);
               
                contador = 0;
                Time.timeScale = 1;
        }
    }
}
