using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej13S : MonoBehaviour
{
    //Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera:  
    //• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar el 16)
    //• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20  por cada hora extra. (crear una constante para almacenar el 20)
    // Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla el salario correspondiente.

    public int horassemanales;

    // Start is called before the first frame update
    void Start()
    {
        int pagoporhora = 16;
        int pagoporhoraextra = 20;
        int salario;
        
        if (horassemanales <= 40)
        {
            salario = pagoporhora * horassemanales;
            Debug.Log("El salario semanal de este obrero es de: " + salario);
        }

        else
        {
            salario = pagoporhoraextra * horassemanales;
            Debug.Log("El salario semanal de este obrero es de: " + salario);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
