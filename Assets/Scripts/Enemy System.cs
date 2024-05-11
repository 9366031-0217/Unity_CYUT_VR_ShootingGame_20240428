using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField, Header("玩家")]
    private Transform PlayerPoint;
    [SerializeField, Header("導覽代理器")]
    private NavMeshAgent agent;

    private void Update()
    {
        agent.SetDestination(PlayerPoint.position);
    }
}
