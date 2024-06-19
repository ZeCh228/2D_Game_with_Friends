using UnityEngine;

public class GroundCheck : MonoBehaviour 
{
    [SerializeField] LayerMask _groundLayer;
    [SerializeField] float _overLapCircleRadius;
    private bool _isGrounded;

    private void Update()
    {
        RaycastGroundChecker();
    }

    public bool RaycastGroundChecker()
    {
        _isGrounded = Physics2D.OverlapCircle(transform.position, _overLapCircleRadius, _groundLayer);
        if( _isGrounded ) 
        {
            Debug.Log("&&Мы на земле");
            return true;
        }
        else 
        {
            Debug.Log("&&Мы не на земле");
            return false;
        }
    }
}
