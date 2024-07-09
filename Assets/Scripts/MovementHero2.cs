using UnityEngine;

public class MovementHero2 : PlayerMovement
{
    [SerializeField] private SitOnSpineAbility _sitOnSpineAbility;
    
    public bool SitOnSpine { private get; set; } = false;
        
    protected override void CheckInput()
    {
        if (SitOnSpine == false)
        {
            int DirectionX = Move();
            Flip(DirectionX);
        }
        
        Jump();
    }
    
    protected override void Jump()
    {
        bool JumpIsPressed = _inputManager.JumpIsPressed();

        if (JumpIsPressed && _groundCheck.IsGrounded == true)
        {
            if (SitOnSpine == true)
            {
                _sitOnSpineAbility.StandUp();
            }
            
            _rb.AddForce(transform.up * jumpheight, ForceMode2D.Impulse);
        }
    }
}
