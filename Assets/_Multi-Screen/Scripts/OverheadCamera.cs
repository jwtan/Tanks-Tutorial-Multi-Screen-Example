using UnityEngine;

public class OverheadCamera : MonoBehaviour
{
    private Camera _camera;
    private int _numDisplays;

    private void Start()
    {
        _camera = GetComponent<Camera>();

        UpdateDisplays();
    }

    private void Update()
    {
        if (_numDisplays == Display.displays.Length)
        {
            return;
        }

        UpdateDisplays();
    }

    private void UpdateDisplays()
    {
        _numDisplays = Display.displays.Length;

        if (_numDisplays > 1)
        {
            Display target = Display.displays[1];
            _camera.SetTargetBuffers(target.colorBuffer, target.depthBuffer);

            _camera.enabled = true;
        }
        else
        {
            _camera.enabled = false;
        }
    }
}
