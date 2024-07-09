using UnityEngine;

public class CatchOnSpine : MonoBehaviour
{
    [SerializeField] private Transform _sitPoint;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private Transform _body;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<SitOnSpineAbility>().Sit(_sitPoint, _layerMask, _body.eulerAngles);
        Debug.Log($"^^{collision.name}");
    }
}
