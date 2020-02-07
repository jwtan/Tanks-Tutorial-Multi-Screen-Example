using UnityEngine;

namespace Complete
{
    public class TankCamera : MonoBehaviour
    {
        [SerializeField]
        private Camera _camera = null;

        public void Setup(int playerNumber)
        {
            if (playerNumber != 1)
            {
                Destroy(_camera.gameObject);
            }
            else
            {
#if !UNITY_EDITOR
                Display target = Display.displays[0];
                _camera.SetTargetBuffers(target.colorBuffer, target.depthBuffer);
#endif
            }
        }
    }
}
