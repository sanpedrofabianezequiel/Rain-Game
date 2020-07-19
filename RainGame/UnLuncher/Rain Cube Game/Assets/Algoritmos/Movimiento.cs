using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"),0,0); //Set movimiento transverzal
                                                                        //Los demas ejes se quedan inmoviles
        
         if(transform.position.x < -10)//Limite Izquierdo
        {                               
            transform.position = new Vector3(-10, -3);
        }else if(transform.position.x > 10)//Limite Derecho
        {
            transform.position = new Vector3(10, -3);
        }

    }

    //////////////////////////////////
    ///Metodo colicionador
    public void OnCollisionEnter()//Metodo por defecto
    {
        SceneManager.LoadScene("SampleScene");//vuelve a la escena
    }



}
