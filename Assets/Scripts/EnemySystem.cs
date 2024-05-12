using UnityEngine;
using UnityEngine.AI;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("玩家")]
    private Transform PlayerPoint;
    [SerializeField, Header("導覽代理器")]
    private NavMeshAgent agent;
    [SerializeField, Header("動畫控制器")]
    private Animator ani;

    private string parMove = "移動數值";

    private void Update()
    {
        agent.SetDestination(PlayerPoint.position);

        ani.SetFloat(parMove, agent.velocity.magnitude / agent.speed);
    }
}
