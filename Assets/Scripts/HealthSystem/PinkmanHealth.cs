using UnityEngine;

public class PinkmanHealth : MonoBehaviour, IHealthSystem //сделать абстрактным 
{
    [SerializeField] int _actualHealth;
    [SerializeField] int _maxHealth = 3;
    [SerializeField] GameObject _pinkmanTomb;
    private Rigidbody2D _rb;
    private PlayerMovement _playerMovement;


    private void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _rb = GetComponent<Rigidbody2D>();
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
        _pinkmanTomb.transform.SetParent(null);
        _pinkmanTomb.SetActive(true);
        gameObject.SetActive(false);
        _rb.velocity = Vector3.zero;
        _playerMovement.enabled = false;

        Debug.Log("PinkmanDie");
    }

    public void OnRespawn()
    {
        _actualHealth = _maxHealth;
        _playerMovement.enabled = true;
    }

    public void TakeDamage(int Damage)
    {
        _actualHealth = _actualHealth - Damage;
        CheckDeath();
    }

    public void Rewive() 
    {
        _playerMovement.enabled = true;
        _actualHealth += 1;
        RemoveTomb();
    }

    private void RemoveTomb() 
    {
        _pinkmanTomb.transform.SetParent(this.transform);
        _pinkmanTomb.SetActive(false);
        this.gameObject.SetActive(true);
    }
}
