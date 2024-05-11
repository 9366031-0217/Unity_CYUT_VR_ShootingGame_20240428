using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField, Header("���a")]
    private Transform PlayerPoint;
    [SerializeField, Header("�����N�z��")]
    private NavMeshAgent agent;

    private void Update()
    {
        agent.SetDestination(PlayerPoint.position);
    }
}
