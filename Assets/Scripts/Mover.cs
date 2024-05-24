using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _moventDirection;
    [SerializeField] private GameObject _gameObject;

    private GameObject _detectObject1;

    private void Start()
    {
        _detectObject1 = GameObject.FindGameObjectWithTag("MovementWhereObjectLooking");
    }

    private void FixedUpdate()
    {
        if(_gameObject == _detectObject1)
        {
            transform.Translate(Vector3.forward * _speed * Time.fixedDeltaTime, Space.Self);
        }
        else
        {
            transform.Translate(_moventDirection.normalized * _speed * Time.fixedDeltaTime);
        }    
    }
}
