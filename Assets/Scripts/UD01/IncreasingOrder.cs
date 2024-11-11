using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{

    //Variables globales
    [SerializeField]
    private int _numberOne,
                _numberTwo,
                _numberThree;


    // Start is called before the first frame update
    void Start()
    {
        
        GetIncresingNumbers();
       
    }

    private void GetIncresingNumbers()
    {
       //Primero pongo la condición general
        if( _numberOne < _numberTwo && _numberTwo < _numberThree)
        {

            Debug.Log("Los números están en orden creciente.");

        }
        //En el caso de que sean iguales
        else if(_numberOne == _numberTwo && _numberTwo == _numberThree)
        {

            Debug.Log("Los números son iguales");

        }
        //en el caso de que no vayan en ningún orden creciente
        else
        {

            Debug.Log("Los números no están están en orden creciente.");

        }



        

    
     }
}
