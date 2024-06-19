using UnityEngine;

public class TargetCinemachine : MonoBehaviour
{
    [SerializeField] Transform _player1;
    [SerializeField] Transform _player2;

    private void Update()
    {
        transform.position = new Vector3(SearchAverage(), this.transform.position.y, this.transform.position.z);
    }

    private float SearchAverage()
    {
        float AverageTransform = (_player1.position.x + _player2.position.x) / 2;
        return AverageTransform;
    }
}
