using UnityEngine;
using UnityEngine.AI;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("���a")]
    private Transform PlayerPoint;
    [SerializeField, Header("�����N�z��")]
    private NavMeshAgent agent;
    [SerializeField, Header("�ʵe���")]
    private Animator ani;

    private string parMove = "���ʼƭ�";

    private void Update()
    {
        agent.SetDestination(PlayerPoint.position);

        ani.SetFloat(parMove, agent.velocity.magnitude / agent.speed);
    }
}
