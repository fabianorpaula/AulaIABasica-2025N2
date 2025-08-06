using UnityEngine;
using UnityEngine.AI;

public class AgenteInteligente : MonoBehaviour
{
    //Para onde vou
    public GameObject Alvo;
    //Uso o componente de Navega��o
    public NavMeshAgent Agente;

    void Start()
    {
        //Capturo o Componente de Navega��o
        Agente = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        Agente.SetDestination(Alvo.transform.position);
    }
}
