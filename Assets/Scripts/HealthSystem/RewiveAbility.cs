using UnityEngine;

public class RewiveAbility : MonoBehaviour
{
    [SerializeField] InputManager _inputManager;
    private IHealthSystem _heroHealth;
    

    private void Start()
    {
        _heroHealth = GetComponentInParent<IHealthSystem>();
        gameObject.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.CompareTag("Player1"));

        if (collision.CompareTag("Player1") || collision.CompareTag("Player2")) 
        {
            if(_inputManager.RewiveIsPressed() == true) 
            {
                _heroHealth.Rewive();
                Debug.Log("Я пытаюсь тебя поднять");
            }
            
        }

    }
}
