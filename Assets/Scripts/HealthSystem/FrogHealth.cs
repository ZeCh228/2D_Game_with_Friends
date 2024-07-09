using UnityEngine;

public class FrogHealth : MonoBehaviour, IHealthSystem
{
    [SerializeField] int _actualHealth;
    [SerializeField] int _maxHealth = 3;
    [SerializeField] SpriteChanger _spriteChanger;
    private PlayerMovement _playerMovement;
    private Animator _animator;


    private void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _animator = GetComponent<Animator>();
    }

    public void CheckDeath()
    {
        if (_actualHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        _spriteChanger.ChangePinkmanSprite(GetComponent<SpriteRenderer>());
        _playerMovement.enabled = false;
        Debug.Log("PinkmanDie");
    }

    public void OnRespawn()
    {
        _actualHealth = _maxHealth;
        _animator.enabled = true;
        _playerMovement.enabled = true;
    }

    public void TakeDamage(int Damage)
    {
        _actualHealth = _actualHealth - Damage;
        CheckDeath();
    }

    public void Rewive()
    {
        throw new System.NotImplementedException();
    }

    /*public void Rewive()
    {
        _actualHealth += 1;
        _animator.enabled = true;
        _playerMovement.enabled = true;
    }*/
}
