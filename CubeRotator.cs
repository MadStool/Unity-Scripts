using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    [SerializeField] private float _rotationSpeed = 90f;
    [SerializeField] private Vector3 _rotationAxis = Vector3.up;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(_rotationAxis * _rotationSpeed * Time.deltaTime);
    }
}