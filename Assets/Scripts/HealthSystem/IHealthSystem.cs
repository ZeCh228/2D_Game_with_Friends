using UnityEngine;

public interface IHealthSystem :  IDamagable
{
    public void TakeDamage(int Damage);
   
    public void OnRespawn();

    public void CheckDeath();

    public void Die();

    public void Rewive();
}
