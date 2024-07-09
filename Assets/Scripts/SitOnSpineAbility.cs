using UnityEngine;

public class SitOnSpineAbility : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private MovementHero2 _movementHero2;
    [SerializeField] private Collider2D _Collider2D; 
    private LayerMask _emptyLayer;

    public void Sit (Transform SitPoint, LayerMask LayerMask, Vector3 Rotation)
    {
        _rb.velocity = Vector2.zero;
        _rb.bodyType = RigidbodyType2D.Kinematic;
        _spriteRenderer.sortingOrder -= 1;
        _movementHero2.SitOnSpine = true;
        _Collider2D.excludeLayers = LayerMask;
        this.transform.position = SitPoint.position;
        this.transform.SetParent(SitPoint);
        this.transform.eulerAngles = Rotation;
    }
    
    public void StandUp ()
    {
        _rb.bodyType = RigidbodyType2D.Dynamic;
        _spriteRenderer.sortingOrder += 1;
        _movementHero2.SitOnSpine = false;
        _Collider2D.excludeLayers = _emptyLayer;
        this.transform.SetParent(null);
    }
}
