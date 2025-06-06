using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [Header("Movement Sttings")]
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private Vector3 _moveDirection = Vector3.forward;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_moveDirection * _moveSpeed * Time.deltaTime);
    }
}