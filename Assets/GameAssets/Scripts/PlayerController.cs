using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int attack1Damage;
    public int attack2Damage;

    public Animator animator;

    public bool isAttacking;
    public EnemyController enemy;
    public void OnAttack1ButonClicked()
    {
        isAttacking = true;
        animator.Play("Attack");
    }
    public void OnAttack2ButtonClicked()
    {
        isAttacking = true;
        animator.Play("Attack2");
    }
    public void ReturnToIdle()
    {
        animator.Play("Idle");
    }
    public void DamageEnemy(float damage)
    {
        enemy.Hurt(damage);
    }
}
