using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector3 _moventDirection;
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        transform.Translate(_moventDirection.normalized * _speed);
    }
}
