using System;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] Transform _followTarget;
    [SerializeField, Range(0f, 1f)] float _parallaxStrength = 0.1f;
    [SerializeField] bool _dasableVerticalParallax;
    Vector3 _targetPreviousPosition;

    private void Start()
    {
        if (!_followTarget)
        {
            _followTarget = Camera.main.transform;
        }
        _targetPreviousPosition = _followTarget.position;
    }

    private void Update()
    {
        Vector3 Delta = _followTarget.position - _targetPreviousPosition;

        if (_dasableVerticalParallax) 
        {
            Delta.y = 0;
        }
        _targetPreviousPosition = _followTarget.position;
        transform.position += Delta * _parallaxStrength;
    }

}


