using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej14S : MonoBehaviour
{
    //Construir un programa que simule el funcionamiento de una calculadora que puede  realizar las cuatro operaciones aritméticas básicas(suma, resta, producto y división) con valores numéricos enteros.
    //Se debe especificar la operación que se desea realizar ingresando una letra por Inspector (s para la suma, r para la resta, p para el producto y d para la división) y luego, deberán ingresarse dos números enteros para así realizar la operación.Informar el resultado por pantalla.Nota: 
    //Se recomienda el empleo de una sentencia switch.

    public int valor1;
    public int valor2;
    public string letraparaoperacion;

    // Start is called before the first frame update
    void Start()
    {
        int resultado;

        switch (letraparaoperacion)
        {
            case "s":
                resultado = valor1 + valor2;
                    Debug.Log("El resultado de esta suma es: " + resultado);
                break;

            case "r":
                resultado = valor1 - valor2;
                    Debug.Log("El resultado de esta resta es: " + resultado);
                break;

            case "m":
                resultado = valor1 * valor2;
                    Debug.Log("El resultado de esta multiplicacion es: " + resultado);
                break;

            case "d":
                resultado = valor1 / valor2;
                    Debug.Log("El resultado de esta division es: " + resultado);
                break;

            default:
                Debug.Log("La letra ingresada no es valida");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
