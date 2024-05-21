using UnityEngine;
    
public class Scale : MonoBehaviour
{
    [SerializeField] private ObjectChanger _objectStatusHandler;
    [SerializeField] private Vector3 _speedScale;

    [SerializeField] private float _speedScaleX;
    [SerializeField] private float _speedScaleY;
    [SerializeField] private float _speedScaleZ;


    private void Start()
    {
        _speedScale = Vector3.one *0.001f;
    }

    private void Update()
    {
        Growth();
    }

    public void Growth()
    {
        transform.localScale = _objectStatusHandler.Growth(_speedScale);
    }
}
