using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {

        GetNumber0To100For();

    }

    private void GetNumber0To100For()
    {
        //primero llamo a los n�meros del 0 al 100, pongo 101 para que se incluya hasta el n�mero 100
        for( int i = 0; i < 101; i++)
        {
            //Luego pongo la condici�n para que sea impar
            if(  i % 2 == 1)
            {

                Debug.Log(i);

            }
            

        }



    }

}
