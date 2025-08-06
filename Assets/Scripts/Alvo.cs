using UnityEngine;
using System.Collections.Generic;


public class Alvo : MonoBehaviour
{
    //MeusCaminhos
    public List<GameObject> Destinos;
    //Para onde vou no momento
    public GameObject DestinoReal;
    
    void Update()
    {
        //Para onde estou indo (atualizado)
        transform.position = Vector3.MoveTowards(
           transform.position,
           DestinoReal.transform.position,
           0.02f);

        float DistanciaFinal = Vector3.Distance(
            transform.position, DestinoReal.transform.position );

        if ( DistanciaFinal < 3)
        {
            int novocaminho = Random.Range( 0, 10 );
            DestinoReal = Destinos[novocaminho];

        }

    }
}
