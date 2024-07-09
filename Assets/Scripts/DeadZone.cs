using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField] DeathManager _respawn;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1") || collision.CompareTag("Player2"))
        {
            _respawn.OnFallDown();
            Debug.Log("Failed");
        }
    }
}
