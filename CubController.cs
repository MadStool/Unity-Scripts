using UnityEngine;

public class CubeController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float _moveSpeed = 3f;

    [Header("Rotation Settings")]
    [SerializeField] private float _rotationSpeed = 45f;

    [Header("Scaling Settings")]
    [SerializeField] private float _scaleSpeed = 0.3f;
    [SerializeField] private float _scaleAmplitude = 0.5f;
    [SerializeField] private float _baseScale = 0.75f;

    private Vector3 _initialScale;
    private float _currentScaleFactor;

    void Start()
    {
        CacheInitialScale();
    }

    void Update()
    {
        Move();
        Rotate();
        Scale();
    }

    private void CacheInitialScale()
    {
        _initialScale = transform.localScale;
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }

    private void Scale()
    {
        _currentScaleFactor = Mathf.PingPong(Time.time * _scaleSpeed, _scaleAmplitude) + _baseScale;

        transform.localScale = _initialScale * _currentScaleFactor;
    }
}