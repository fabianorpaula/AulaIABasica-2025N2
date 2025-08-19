using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AlvoInteligente : MonoBehaviour
{

    public NavMeshAgent agente;

    //MeusCaminhos
    public List<GameObject> Destinos;
    //Para onde vou no momento
    public GameObject DestinoReal;

    public void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        DestinoReal = Destinos[0];
    }

    void Update()
    {
        agente.SetDestination(DestinoReal.transform.position);

        float DistanciaFinal = Vector3.Distance(
            transform.position, DestinoReal.transform.position);

        if (DistanciaFinal < 3)
        {
            int novocaminho = Random.Range(0, 10);
            DestinoReal = Destinos[novocaminho];

        }

    }

}
