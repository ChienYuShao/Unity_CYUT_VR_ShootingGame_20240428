using UnityEngine;

public class HpPlayer : HpSystem
{
    private string enemyAttackArea = "�ĤH����";

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains(enemyAttackArea))
        {
            Damage(50);
        }
    }
}
