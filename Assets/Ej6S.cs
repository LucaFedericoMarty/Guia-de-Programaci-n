using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej6S : MonoBehaviour
{
    // Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0 en una variable 
    // llamada num1 y muestre un mensaje por pantalla indicando "el  número es par" o "el número es impar". 
    // Deberá utilizar el operador “módulo” es el caracter  %.

    public int num1 = 5;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 <= 0)
        {
            Debug.Log("ERROR, la variable es igual o menor a 0");
        }

        else if (num1 % 2 > 0)
        {
            Debug.Log("El numero es impar");
        }

        else
        {
            Debug.Log("El numero es par");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
