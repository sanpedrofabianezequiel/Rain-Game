using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lluviaCubos : MonoBehaviour
{
    public float Delay = 0.1f; //Es el retraso en que apresca un nuevo cubo
    public GameObject cubox;    //Lo qye va a aprecer es un CUBO

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Inicio", Delay, Delay);//(metodo,tiempo demora,repeticion)

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Inicio()    //Metodo  Va crear un cubo nuevo en un lugar ALAZAR
    {
        Instantiate(cubox,  //Que objeto vamos a crear
                        new Vector3 (Random.Range(-10,10),//En que posicion del eje X
                            10,                             //En que posicion del eje Y
                                0),                            //En el EJE Z
                                    Quaternion.identity );       //  
      

            
    }

}
