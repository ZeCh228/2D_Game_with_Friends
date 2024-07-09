using UnityEngine;

public class Finish : MonoBehaviour
{
    private bool _playerOneFinish;
    private bool _playerTwoFinish;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            _playerOneFinish = true;
            CheckVictory();
        }
        else if (collision.CompareTag("Player2"))
        {
            _playerTwoFinish = true;
            CheckVictory();
        }    
    }

    private void CheckVictory()
    {
        if (_playerOneFinish == true && _playerTwoFinish == true)
        {
            Debug.Log("Victory!");
        }
    }

    private void OnTriggerExit2D(Collider2D collisionExit)
    {
        if (collisionExit.CompareTag("Player1"))
        {
            _playerOneFinish = false;
        }
        else if (collisionExit.CompareTag("Player2"))
        {
            _playerTwoFinish = false;
        }
    }
}
