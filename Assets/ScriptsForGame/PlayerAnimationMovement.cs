using UnityEngine;

public class PlayerAnimationMovement : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] GroundCheck _groundCheck;
    private Rigidbody2D rb;
    private int _velocityX = Animator.StringToHash("VelocityX");
    private int _isGrounded = Animator.StringToHash("IsGrounded");


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _animator.SetBool(_isGrounded, _groundCheck.IsGrounded);
        _animator.SetFloat(_velocityX, Mathf.Abs(rb.velocity.x)); 
    }
}  