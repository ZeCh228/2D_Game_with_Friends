using System;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    [SerializeField] HealthSystem _healthPlayer1;
    [SerializeField] HealthSystem _healthPlayer2;

    
    public void OnFallDown() 
    {
        _healthPlayer1.TakeDamage(Int32.MaxValue);
        _healthPlayer2.TakeDamage(Int32.MaxValue);
        _healthPlayer1.OnRespawn();
        _healthPlayer2.OnRespawn();
        Teleport();

        void Teleport() 
        {
            _healthPlayer1.transform.position = _healthPlayer2.transform.position = this.transform.position;
        }
    } 
}
