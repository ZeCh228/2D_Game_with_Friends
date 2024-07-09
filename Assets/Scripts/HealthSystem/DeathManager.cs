using System;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    [SerializeField] FrogHealth _frogHealth;
    [SerializeField] PinkmanHealth _pinkmandHealth;

    
    public void OnFallDown() 
    {
        _frogHealth.TakeDamage(Int32.MaxValue);
        _pinkmandHealth.TakeDamage(Int32.MaxValue);
        _frogHealth.OnRespawn();
        _pinkmandHealth.OnRespawn();
        Teleport();

        void Teleport() 
        {
            _frogHealth.transform.position = _pinkmandHealth.transform.position = this.transform.position;
        }
    } 
}
