using UnityEngine;
    
public class Scale : MonoBehaviour
{
    [SerializeField] private Vector3 _speedScale;
    [SerializeField] private float _zoomStep = 0.5f;

    private void Start()
    {
        _speedScale = Vector3.one * _zoomStep;
    }

    private void Update()
    { 
        transform.localScale += _speedScale * Time.deltaTime;
    }
}
