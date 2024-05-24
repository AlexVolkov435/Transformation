using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedRotation;

    private void FixedUpdate()
    {
        transform.rotation *= Quaternion.Euler(0, _speedRotation * Time.fixedDeltaTime, 0);
    }
}