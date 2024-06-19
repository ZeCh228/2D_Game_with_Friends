using UnityEngine;

public class HealthSystem : MonoBehaviour, IDamagable
{
    [SerializeField] int _actualHealth;
    [SerializeField] int _maxHealth = 3;

    public void TakeDamage(int Damage)
    {
        _actualHealth = _actualHealth - Damage;
        CheckDeath();
    }

    public void OnRespawn()
    {
        _actualHealth = _maxHealth;
    }

    private void CheckDeath()
    {
        if (_actualHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("!We die");
    }
}
