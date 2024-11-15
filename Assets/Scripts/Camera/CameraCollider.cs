using UnityEngine;

namespace ScriptsForGame.CameraLupaza
{
    public class CameraColllider : MonoBehaviour
    {
        [SerializeField] private  Transform _leftCollider, _rightCollider, _upCollider;
        [SerializeField] private  Camera _camera;
        private readonly Vector3 _leftSide = new Vector3(0, 0.5f);
        private readonly Vector3 _rightSide = new Vector3(1f, 0.5f);
        private readonly Vector3 _upSide = new Vector3(0.5f, 1f);
        
        void Start()
        {
            CorrectionColliderPosition();
        }                  

        public void CorrectionColliderPosition()
        {
            var WSleftSide = _camera.ViewportToWorldPoint(_leftSide);
            var WSrightSide = _camera.ViewportToWorldPoint(_rightSide);
            var WSUpSide = _camera.ViewportToWorldPoint(_upSide);
            
            _leftCollider.position = WSleftSide;
            _rightCollider.position = WSrightSide;
            _upCollider.position = WSUpSide;
        }
    }
}

