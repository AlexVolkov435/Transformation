using UnityEngine;
    
public class Scale : MonoBehaviour
{
    [SerializeField] private ObjectChanger _objectStatusHandler;

    [SerializeField] private float _speedScaleX;
    [SerializeField] private float _speedScaleY;
    [SerializeField] private float _speedScaleZ;

    private void Start()
    {
        _speedScaleX = 0.001f;
        _speedScaleY = 0.001f;
        _speedScaleZ = 0.001f;
    }

    private void Update()
    {
        Growth();
    }

    public void Growth()
    {
        transform.localScale = _objectStatusHandler.Growth(_speedScaleX, _speedScaleY, _speedScaleZ);
    }
}
