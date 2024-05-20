using UnityEngine;

public class Transformation : MonoBehaviour
{
    [SerializeField] private ObjectChange _objectChange;

    [SerializeField] private float _speedRotate;
    [SerializeField] private float _speedMovent;
    [SerializeField] private float _speedScaleX;
    [SerializeField] private float _speedScaleY;
    [SerializeField] private float _speedScaleZ;

    private void Start()
    {
        _speedRotate = 1f;
        _speedMovent = 0.01f;

        _speedScaleX = 0.001f;
        _speedScaleY = 0.001f;
        _speedScaleZ = 0.001f;
    }

    private void FixedUpdate()
    {
        Modification();
    }

    private void Modification()
    {
        transform.Translate(Vector3.forward * _speedMovent, Space.World);
        transform.localScale = _objectChange.Growth(_speedScaleX, _speedScaleY, _speedScaleZ);
        transform.rotation = _objectChange.Rotate(_speedRotate);
    }
}
