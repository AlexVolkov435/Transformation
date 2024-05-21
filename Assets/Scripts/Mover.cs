using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Object _objectNameFaceMovement;
    [SerializeField] private ObjectChanger _objectStatusHandler;
    [SerializeField] private Vector3 _moventDirection;
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        if(_objectStatusHandler.NameFaceMovement == _objectNameFaceMovement)
        {
            transform.Translate(Vector3.forward * _speed, Space.World);
        }
        else
        {
            transform.Translate(_moventDirection.normalized * _speed);
        }
    }
}
