using UnityEngine;

public class ObjectChanger: MonoBehaviour
{

    [SerializeField] public Object _objectFaceMovement;

    public Object NameFaceMovement => _objectFaceMovement;

    public Vector3 Growth(float _speedScaleX, float _speedScaleY, float _speedScaleZ)
    {
        return transform.localScale += new Vector3(_speedScaleX, _speedScaleY, _speedScaleZ);
    }

    public Quaternion Rotate(float _speedRotation)
    {
        return transform.rotation *= Quaternion.Euler(0, _speedRotation, 0);
    }
}