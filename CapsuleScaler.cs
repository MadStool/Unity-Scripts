using UnityEngine;

public class CapsuleScaler : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float _scaleSpeed = 0.5f;
    [SerializeField] private float _scaleAmplitude = 0.5f;
    [SerializeField] private float _baseScaleMultiplier = 0.5f;

    private Vector3 _initialScale;
    private float _currentScaleFactor;

    void Start() => CacheInitialScale();

    void Update() => UpdateScaling();

    private void CacheInitialScale()
    {
        _initialScale = transform.localScale;
    }

    private void UpdateScaling()
    {
        _currentScaleFactor = Mathf.PingPong(Time.time * _scaleSpeed, _scaleAmplitude) + _baseScaleMultiplier;

        transform.localScale = _initialScale * _currentScaleFactor;
    }
}