using UnityEngine;

public class GeneralCamera : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _target;
    private Vector3 _startPosition;

    private void Update()
    {
        RotateToTarget(_target);
    }

    public void Init(Transform target)
    {
        _target = target;
        _startPosition = this.transform.position;
    }

    public void Init(Transform target, Vector3 position)
    {
        _target = target;
        _startPosition = position;
        this.transform.position = position;
    }

    private void RotateToTarget(Transform target)
    {
        transform.RotateAround(target.position, target.up, Time.deltaTime * _speed);
        transform.LookAt(target);
    }
}
