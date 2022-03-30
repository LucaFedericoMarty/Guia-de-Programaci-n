using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5S : MonoBehaviour
{
    public int num1 = 6;
    public int num2 = 3;

    // Start is called before the first frame update
    void Start()
    {
        float resultado = num1 / num2;
        Debug.Log("El resultado de la división entre ambas variables es " + resultado + "");

        if (num2 == 0)
        {
            Debug.Log("ERROR, no se puede dividir por cero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
