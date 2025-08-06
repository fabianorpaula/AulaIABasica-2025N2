using UnityEngine;

public class Agente : MonoBehaviour
{
    public GameObject Alvo;
   
    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(
            transform.position,
            Alvo.transform.position,
            0.01f);
    }
}
