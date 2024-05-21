using UnityEngine;

public class ObjectChanger: MonoBehaviour
{

    [SerializeField] public Object _objectFaceMovement;

    public Object NameFaceMovement => _objectFaceMovement;

    public Vector3 Growth(Vector3 vector3)
    {
        return transform.localScale += vector3;
    }

    public Quaternion Rotate(float _speedRotation)
    {
        return transform.rotation *= Quaternion.Euler(0, _speedRotation, 0);
    }
}