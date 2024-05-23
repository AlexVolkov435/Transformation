using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedRotation;

    private void Start()
    {
        _speedRotation = 100;
    }

    private void FixedUpdate()
    {
        transform.rotation *= Quaternion.Euler(0, _speedRotation * Time.fixedDeltaTime, 0);
    }
}
