using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AlvoInteligente : MonoBehaviour
{

    public NavMeshAgent MeuAlvo;

    //MeusCaminhos
    public List<GameObject> Destinos;
    //Para onde vou no momento
    public GameObject DestinoReal;

    public void Start()
    {
        MeuAlvo = GetComponent<NavMeshAgent>();
        MeuAlvo.speed = 40;
        DestinoReal = Destinos[0];
    }

    void Update()
    {
        MeuAlvo.SetDestination(DestinoReal.transform.position);
        
        float DistanciaFinal = Vector3.Distance(
            transform.position, DestinoReal.transform.position);

        if (DistanciaFinal < 7)
        {
            int novocaminho = Random.Range(0, 10);
            DestinoReal = Destinos[novocaminho];

        }

    }

}
