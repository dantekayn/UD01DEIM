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
       //Primero pongo la condici�n general
        if( _numberOne < _numberTwo && _numberTwo < _numberThree)
        {

            Debug.Log("Los n�meros est�n en orden creciente.");

        }
        //En el caso de que sean iguales
        else if(_numberOne == _numberTwo && _numberTwo == _numberThree)
        {

            Debug.Log("Los n�meros son iguales");

        }
        //en el caso de que no vayan en ning�n orden creciente
        else
        {

            Debug.Log("Los n�meros no est�n est�n en orden creciente.");

        }



        

    
     }
}
