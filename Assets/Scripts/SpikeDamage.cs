using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    [SerializeField] int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1") || collision.CompareTag("Player2"))
        {
            collision.GetComponent<IHealthSystem>().TakeDamage(damage);
        }
    }
}
