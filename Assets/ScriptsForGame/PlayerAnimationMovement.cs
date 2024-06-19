using UnityEngine;

public class PlayerAnimationMovement : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] GroundCheck _groundCheck;
    private int _magnitudeX = Animator.StringToHash("MagnitudeX");
    private int _isGrounded = Animator.StringToHash("IsGrounded");


    private void Update()
    {
        if (_groundCheck.RaycastGroundChecker() == true)
        {
            _animator.SetBool(_isGrounded, true);
        }
        else 
        {
            _animator.SetBool(_isGrounded, false);
        }   
    }
}