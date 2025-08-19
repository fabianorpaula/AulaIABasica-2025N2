using UnityEngine;
using UnityEngine.AI;

public class AgenteInteligenten2 : MonoBehaviour
{
    //Para onde vou
    public GameObject Alvo;
    //Uso o componente de Navegação
    public NavMeshAgent Agente;
    public bool estadoPerseguir = false;

    void Start()
    {
        //Capturo o Componente de Navegação
        Agente = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        VerificarDistancia();
        Perseguir();
    }

    void VerificarDistancia()
    {
        float DistanciaParaOAlvo = Vector3.Distance(
                transform.position,
                Alvo.transform.position);

        if (DistanciaParaOAlvo < 8)
        {
            estadoPerseguir = true;
            Agente.speed = 30;
        }

        if (DistanciaParaOAlvo > 14)
        {
            estadoPerseguir = false;
            Agente.speed = 0;
        }

    }

    void Perseguir()
    {
        if (estadoPerseguir == true)
        {
            Agente.SetDestination(Alvo.transform.position);
        }
    }
}
