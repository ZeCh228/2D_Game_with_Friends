using UnityEngine;

public class InputManager : MonoBehaviour 
{
    [SerializeField] private KeyCode _moveLeft, _moveRight, _jump, _attack;
    [SerializeField] private KeyCode _rewiveKey;

    public bool JumpIsPressed() =>  Input.GetKeyDown(_jump);
    public bool RewiveIsPressed() => Input.GetKeyDown(_rewiveKey);
    public int ReadMovement() 
    {
        if (Input.GetKey(_moveLeft)) 
        {
            return -1;
        }
        
        if (Input.GetKey(_moveRight)) 
        {
            return 1;
        }
        return 0; 
    }
}
