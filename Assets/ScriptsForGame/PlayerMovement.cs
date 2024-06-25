using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpheight;
    [SerializeField] GroundCheck _groundCheck;
    [SerializeField] InputManager _inputManager;


    private Rigidbody2D _rb;
    private Animator anim;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        int DirectionX = Move();
        Jump();

        Flip(DirectionX);
    }

    private int Move()
    {
        int DirectionX = _inputManager.ReadMovement();
        _rb.velocity = new Vector2(DirectionX * speed, _rb.velocity.y);
        return DirectionX;
    }

    private void Jump()
    {
        bool JumpIsPressed = _inputManager.JumpIsPressed();

        if (JumpIsPressed && _groundCheck.IsGrounded == true)
        {
            _rb.AddForce(transform.up * jumpheight, ForceMode2D.Impulse);
        }
    }

    void Flip(int DirectionX)
    {
        if (DirectionX > 0) 
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }    
        else if (DirectionX < 0) 
        { 
            transform.localRotation = Quaternion.Euler(0, 180, 0); 
        }  
    }
}
