using UnityEngine;
    
public class Scale : MonoBehaviour
{
    [SerializeField] private Vector3 _speedScale;

    private void Start()
    {
        _speedScale = Vector3.one *0.5f;
    }

    private void Update()
    { 
        transform.localScale += _speedScale * Time.deltaTime;
    }
}
