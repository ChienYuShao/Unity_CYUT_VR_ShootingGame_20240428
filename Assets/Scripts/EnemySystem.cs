using UnityEngine;
using UnityEngine.AI;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("���a")]
    private Transform playerPoint;
    [SerializeField,Header("�����N�z��")]
    private NavMeshAgent agent;
    [SerializeField, Header("�ʵe���")]
    private Animator ani;

    private string parMove = "���ʼƭ�";
    private string parAttack = "Ĳ�o����";


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
