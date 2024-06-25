using UnityEngine;

public class CatchOnSpine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"^^{collision.name}");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
    }
}
