using UnityEngine;

public class TankInput : MonoBehaviour
{
    [SerializeField] private Tank _actualTank;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _actualTank.Shoot();
        }
    }
}