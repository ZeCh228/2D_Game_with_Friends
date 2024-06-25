using UnityEngine;
using UnityEngine.UIElements;

public class GroundCheck : MonoBehaviour 
{
    [SerializeField] LayerMask _groundLayer;
    [SerializeField] float _overLapCircleRadius;
    [SerializeField] Transform _overlapPoint;

    [field:SerializeField] public bool IsGrounded { get; private set; }

    private void Update()
    {
        IsGrounded = RaycastGroundChecker();
    }

    private bool RaycastGroundChecker()
    {
        return Physics2D.OverlapCircle(_overlapPoint.position, _overLapCircleRadius, _groundLayer);
    }

  /*  private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(_overlapPoint.position, _overLapCircleRadius);
    }*/
}
