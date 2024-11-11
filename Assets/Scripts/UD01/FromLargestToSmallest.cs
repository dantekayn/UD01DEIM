using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
   
    //zona de variables globales
    [SerializeField]
    private int _numberOne,
                _numberTwo,
                _numberThree;

    // Start is called before the first frame update
    void Start()
    {

        IsDescendingNumber();

    }

    private void IsDescendingNumber()
    {
        //Primer caso -> La condición como general
        if (_numberOne > _numberTwo && _numberOne > _numberThree)
        {
            //Para tenerlo más claro hice uno por uno cada _number
            //de extremo a extremo
            //En este caso solo cambié el signo de < a >
            //primer caso -> _numberOne es mayor a todos
            if (_numberTwo > _numberThree)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberOne + "\t" + _numberTwo + "\t" + _numberThree);
            }
            else if (_numberThree > _numberTwo)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberOne + "\t" + _numberThree + "\t" + _numberTwo);
            }
            else if (_numberThree == _numberTwo)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberOne + "\t" + _numberThree + "\t" + _numberTwo);
            }
        }
        //Segundo caso -> _numberTwo es mayor a todos
        if (_numberTwo > _numberOne && _numberTwo > _numberThree)
        {
            
            if (_numberOne > _numberThree)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberTwo + "\t" + _numberOne + "\t" + _numberThree);
            }
            else if (_numberThree > _numberOne)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberTwo + "\t" + _numberThree + "\t" + _numberOne);
            }
            else if (_numberThree == _numberOne)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberTwo + "\t" + _numberThree + "\t" + _numberOne);
            }
        }
        //Tercer caso -< _numberThree es mayor a todos
        if (_numberThree > _numberOne && _numberThree > _numberTwo)
        {
           
            if (_numberOne > _numberTwo)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberThree + "\t" + _numberOne + "\t" + _numberTwo);
            }
            else if (_numberTwo > _numberOne)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberThree + "\t" + _numberTwo + "\t" + _numberOne);
            }
            else if (_numberTwo == _numberOne)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberThree + "\t" + _numberTwo + "\t" + _numberOne);
            }
        }
        //Cuarto caso -> todos los números son iguales
        if (_numberThree == _numberOne && _numberThree == _numberTwo)
        {
            Debug.Log("No existe un orden de mayor a menor de estos números: " + _numberOne + "\t" + _numberTwo + "\t" + _numberThree);
        }

        //Quinto caso -> _numberOne y _numberTwo son iguales y son mayores que _numberThree
        if (_numberOne == _numberTwo && _numberOne > _numberThree)
        {
            Debug.Log("El orden de mayor a menor de estos números es: " + _numberOne + "\t" + _numberTwo + "\t" + _numberThree);
        }

        //Sexto caso -> _numberOne y _numberThree son iguales y son mayores que _numberTwo
        if (_numberOne == _numberThree && _numberOne > _numberTwo)
        {
            Debug.Log("El orden de mayor a menor de estos números es: " + _numberOne + "\t" + _numberThree + "\t" + _numberTwo);
        }

        //Septimo caso -> _numberTwo y _numberThree son iguales y son mayores que _numberOne
        if (_numberTwo == _numberThree && _numberTwo > _numberOne)
        {
            Debug.Log("El orden de mayor a menor de estos números es: " + _numberTwo + "\t" + _numberThree + "\t" + _numberOne);
        }
    }


}

