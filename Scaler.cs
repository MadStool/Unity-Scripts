using UnityEngine;

public class Scaler : MonoBehaviour
{
    [Header("Scaling Settings")]
    [SerializeField] private float _scaleSpeed = 0.1f;
    [SerializeField] private float _maxScaleFactor = 2f;

    private Vector3 _initialScale;
    private float _currentScaleFactor = 1f;

    private void Start()
    {
        CacheInitialScaleObject();
    }

    private void Update()
    {
        UpdateScaling();
    }

    private void CacheInitialScaleObject()
    {
        _initialScale = transform.localScale;
    }

    private void UpdateScaling()
    {
        _currentScaleFactor = Mathf.Min(_currentScaleFactor + _scaleSpeed * Time.deltaTime, _maxScaleFactor);

        transform.localScale = _initialScale * _currentScaleFactor;
    }
}
