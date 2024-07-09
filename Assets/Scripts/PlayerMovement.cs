using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float jumpheight;
    [SerializeField] protected GroundCheck _groundCheck;
    [SerializeField] protected InputManager _inputManager;
    
    protected Rigidbody2D _rb;
    private Animator anim;

    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckInput();
    }

    protected virtual void CheckInput()
    {
        int DirectionX = Move();
        Jump();

        Flip(DirectionX);
    }

    protected int Move()
    {
        int DirectionX = _inputManager.ReadMovement();
        _rb.velocity = new Vector2(DirectionX * speed, _rb.velocity.y);
        return DirectionX;
    }

    protected virtual void Jump()
    {
        bool JumpIsPressed = _inputManager.JumpIsPressed();

        if (JumpIsPressed && _groundCheck.IsGrounded == true)
        {
            _rb.AddForce(transform.up * jumpheight, ForceMode2D.Impulse);
        }
    }

    protected void Flip(int DirectionX)
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
