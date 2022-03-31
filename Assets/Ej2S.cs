using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2S : MonoBehaviour
{
    // Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,  respectivamente, realice la 
    // operación correspondiente y muestre el resultado en pantalla: 
    // a.Suma
    // b.Producto
    
    // Start is called before the first frame update
        void Start()
    {
        int num1 = 4;
        int num2 = 5;
        int sum = num1 + num2;
        int pro = num1 * num2;
        Debug.Log("El resultado entre sumar estas dos varaibles es " + sum + "");
        Debug.Log("El resultado entre multiplicar estas dos varaibles es " + pro + "");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
