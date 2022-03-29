using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jero1 : MonoBehaviour
{
    public int num1 = 4;
    public int num2 = 5;
    public string operacion;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Qué operación queres que haga?");
        if (operacion == "Suma" || operacion == "suma")
        {
            Debug.Log(num1 += num2);
        }

        else if (operacion == "Producto" || operacion == "producto")
        {
            Debug.Log(num1 *= num2)                     ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
