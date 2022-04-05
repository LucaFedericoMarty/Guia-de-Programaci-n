using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej12S : MonoBehaviour
{
// En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje  obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes  resultados:  
//• Si los tres dados son seis, mostrar el mensaje “Excelente” 
//• Si dos dados son seis, mostrar el mensaje “Muy bien”  
//• Si un dado es seis, mostrar el mensaje “Regular”  
//• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente”


    public int dado1 = 6;
    public int dado2 = 6;
    public int dado3 = 6;

    // Start is called before the first frame update
    void Start()
    {
        if (dado1 == 6 && dado2 == 6 && dado3 == 6)
        {
            Debug.Log("Excelente");
        }

        else if (dado1 == 6 && dado2 == 6 | dado1 == 6 && dado3 == 6 | dado2 == 6 && dado3 == 6)
        {
            Debug.Log("Muy bien");
        }

        else if (dado1 == 6 | dado2 == 6 | dado3 == 6)
        {
            Debug.Log("Regular");
        }

        else
        {
            Debug.Log("Insuficiente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
