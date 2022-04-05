using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej11S : MonoBehaviour
{
    //Realizá un programa que resuelva el siguiente problema:  
    //Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:  YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del producto comprado.Mostrá a modo de ticket, la información ingresada y el monto a pagar.Modelo de Ticket:  
    //Fecha de Compra: YYYYMMDD
    //Nombre del Comprador: xxxxx xxxxx
    //Producto solicitado: xxxxx
    //Cantidad solicitada: xx
    //Precio Unitario: $xxx

    public string fdc;
    public string nom;
    public string nompro;
    public int cantpro;
    public int precpro;

    // Start is called before the first frame update
 void Start()
    {
        Debug.Log("Fecha de compra: " + fdc);
        Debug.Log("Nombre del Comprador: " + nom);
        Debug.Log("Producto Solicitado: " + nompro);
        Debug.Log("Cantidad solicitada: " + cantpro);
        Debug.Log("Precio Unitario: " + precpro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
