using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej15S : MonoBehaviour
{
    // Existen dos reglas que identifican dos conjuntos de valores: 
    //- El número es de un solo dígito.
    //- El número es impar.
    //A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA, estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda, para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a  ninguno, respectivamente.
    //Definí un lote de prueba de varios números y probá el algoritmo, escribiendo los resultados.

    public int numero;

    // Start is called before the first frame update
    void Start()
    {
        bool estaEnA;
        bool estaEnB;
        bool estaEnAmbos;
        bool noEstaEnNinguno;

        estaEnA = numero % 2 > 0;
        estaEnB = numero < 10;
        estaEnAmbos = (numero % 2 > 0) && (numero < 10);
        noEstaEnNinguno = (numero % 2 < 0) && (numero > 10);

        if (estaEnA)
        {
            Debug.Log("El numero es impar");
        }

        if (estaEnB)
        {
            Debug.Log("El numero es de una cifra");
        }

        if (estaEnAmbos)
        {
            Debug.Log("El numero es tanto impar como de una cifra");
        }

        if (noEstaEnNinguno)
        {
            Debug.Log("El numero no es ni impar ni de una cifra");
        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
