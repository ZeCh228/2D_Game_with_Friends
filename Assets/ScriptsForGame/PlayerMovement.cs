using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpheight;
    [SerializeField] Transform groundCheck;
    [SerializeField] InputManager _inputManager;


    private Rigidbody2D _rb;
    private bool _isGrounded;
    private Animator anim;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        int DirectionX;
        bool JumpIsPressed;
        Jump(out DirectionX, out JumpIsPressed);

        Flip(DirectionX);
        CheckGround();
    }

    private void Jump(out int DirectionX, out bool JumpIsPressed)
    {
        DirectionX = _inputManager.ReadMovement();
        JumpIsPressed = _inputManager.JumpIsPressed();

        _rb.velocity = new Vector2(DirectionX * speed, _rb.velocity.y);

        if (JumpIsPressed && _isGrounded)
        {
            _rb.AddForce(transform.up * jumpheight, ForceMode2D.Impulse);
        }
    }

    void Flip(int DirectionX)
    {
        if (DirectionX < 0) 
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
            
        if (DirectionX > 0) 
        { 
            transform.localRotation = Quaternion.Euler(0, 180, 0); 
        }  
    }

    void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 1);
        _isGrounded = colliders.Length > 1;
    }  
}
