using UnityEngine;
using UnityEngine.AI;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("玩家")]
    private Transform playerPoint;
    [SerializeField,Header("導覽代理器")]
    private NavMeshAgent agent;
    [SerializeField, Header("動畫控制器")]
    private Animator ani;

    private string parMove = "移動數值";
    private string parAttack = "觸發攻擊";


    private void Update()
    {
        Move();
    }

    private void Move()
    {
        agent.SetDestination(playerPoint.position);

        ani.SetFloat(parMove, agent.velocity.magnitude / agent.speed);
    }
}
