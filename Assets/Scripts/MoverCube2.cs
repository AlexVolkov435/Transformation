using UnityEngine;

public class MoverCube2 : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * _speed * Time.fixedDeltaTime, Space.Self);
    }
}
