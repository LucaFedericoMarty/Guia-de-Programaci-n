using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4S : MonoBehaviour
{
    // Realizá un programa que permita ingresar dos números enteros num1 y num2 por Inspector. 
    // Luego, mostrar el resultado de la suma entre ambos al ejecutar la escena utilizando el siguiente formato: 
    // “La  suma entre “ + num1 + “ y “ + num2 + “ da como resultado “ + num1 + num2.

    public int num1 = 3;
    public int num2 = 5;

    // Start is called before the first frame update
    void Start()
    {
        int sum = num1 + num2;
        Debug.Log("La suma entre " + num1 + " y " + num2 +" da como resultado "+sum+"");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
