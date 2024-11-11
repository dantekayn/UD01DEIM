using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GetNumber0To100For();

    }

    private void GetNumber0To100For()
    {
        //primero llamo a los números del 0 al 100, pongo 101 para que se incluya hasta el número 100
        for ( int i = 0; i < 101; i++)

        {
            //Luego pongo la condición para que sea par
            if ( i % 2 == 0)
            {
                Debug.Log(i);

            }

        }

    }
    
}
