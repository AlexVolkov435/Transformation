using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedRotation;

    private void Start()
    {
        _speedRotation = 10;
    }

    private void FixedUpdate()
    {
        Rotate();
    }

    public void Rotate()
    {
        transform.Rotate(new Vector3(0, _speedRotation, 0));
    }
}
