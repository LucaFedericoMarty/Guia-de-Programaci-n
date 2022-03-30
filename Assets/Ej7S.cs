using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7S : MonoBehaviour
{
    public int num1 = 1;
    public int num2 = 3;
    public int num3 = 5;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2 & num2 == num3)
        {
            Debug.Log("Son los tres iguales");
        }

        else if (num1 > num2 & num1 > num3)

        {
            Debug.Log("El valor mas alto es " + num1 + "");
        }

        else if (num2 > num1 & num2 > num3)
        {
            Debug.Log("El valor mas alto es " + num2 + "");

        }

        else
        {

            Debug.Log("El valor mas alto es " + num3 + "");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
