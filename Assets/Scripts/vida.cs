using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vida : MonoBehaviour
{



 public Image barraDevida;
 public float vidaActual; 
 public float vidaMaxima;    
    // Update is called once per frame
    void Update()
    {
        barraDevida.fillAmount = vidaActual/vidaMaxima; 
       
    }
}
