using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Addition : MonoBehaviour
{
    //Variables globales
    [SerializeField]
    private int _number;
               

    // Start is called before the first frame update
    void Start()
    {
        //variable local para llamar al m�todo
        int _result = GetAddition(_number);
        Debug.Log("La suma de los n�meros del 1 al " + _number + " es: " + _result);


    }

    //se crea el m�todo que sumar� del 1 al _number
    private int GetAddition(int _number)
    {
        //creo una variable local para la suma
        int _addition = 0;
        //creo un bucle que sumar� todos los n�meros del 1 hasta el _number
        for(int i = 1; i <= _number; i++)
        {
            _addition = _addition + i;
        }
        return _addition;
    }
    
   
         
            

       
      
        
        
 }
    

       


        
        
        



    

