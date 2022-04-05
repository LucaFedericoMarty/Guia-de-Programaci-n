using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej9S : MonoBehaviour
{
    // Realizá un programa que resuelva el siguiente problema:  
    // Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del total aportó cada una 
    // (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.
    // Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
    // Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

    public float cap1;
    public float cap2;
    public float cap3;
    public string nom1;
    public string nom2;
    public string nom3;

    // Start is called before the first frame update
    void Start()
    {
        float captot = cap1 + cap2 + cap3;
        float porc1 = (cap1 / captot) * 100;
        float porc2 = (cap2 / captot) * 100;
        float porc3 = (cap3 / captot) * 100;

        Debug.Log("Nombre: " + nom1);
        Debug.Log("Capital aportado: $" + cap1);
        Debug.Log("Porcentaje del capital: %" + porc1);
        Debug.Log("Monto total aportado: $" + captot);

        Debug.Log("Nombre: " + nom2);
        Debug.Log("Capital aportado: $" + cap2);
        Debug.Log("Porcentaje del capital: %" + porc2);
        Debug.Log("Monto total aportado: $" + captot);

        Debug.Log("Nombre: " + nom3);
        Debug.Log("Capital aportado: $" + cap3);
        Debug.Log("Porcentaje del capital: %" + porc3);
        Debug.Log("Monto total aportado: $" + captot);

        // Update is called once per frame
        void Update()
        {

        }
    }
}