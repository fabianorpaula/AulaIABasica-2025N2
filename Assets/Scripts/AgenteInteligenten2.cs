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


        DrawCircleAround(transform.position, radius, segments);
    }

    void VerificarDistancia()
    {
        float DistanciaParaOAlvo = Vector3.Distance(
                transform.position,
                Alvo.transform.position);

        if (DistanciaParaOAlvo < 10)
        {
            estadoPerseguir = true;
            Agente.speed = 30;
        }

        if (DistanciaParaOAlvo > 25)
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

    public float radius = 5f;
    public int segments = 50; // quanto maior, mais suave o círculo
    public Color circleColor = Color.green;

    void DrawCircleAround(Vector3 center, float radius, int segments)
    {
        float angleStep = 360f / segments;
        Vector3 prevPoint = center + new Vector3(Mathf.Cos(0), 0, Mathf.Sin(0)) * radius;

        for (int i = 1; i <= segments; i++)
        {
            float angle = i * angleStep * Mathf.Deg2Rad;
            Vector3 nextPoint = center + new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;

            Debug.DrawLine(prevPoint, nextPoint, circleColor);

            prevPoint = nextPoint;
        }
    }
}
