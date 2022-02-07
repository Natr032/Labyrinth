using System.Collections;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] Transform _transform;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private int _maxPositionY;
    [SerializeField] private float _step = 0.1f;
    [SerializeField] private float _speed = 1f;

    private float _minPositionY;
    private bool _isMoving;
    private WaitForFixedUpdate _wait;

    private void Awake()
    {
        _wait = new WaitForFixedUpdate();
    }

    private void Start()
    {
        _minPositionY = _transform.position.y;

        StartCoroutine(RandomWave());
    }

    private IEnumerator RandomWave()
    {
        if (_transform.position.y == _minPositionY)
        {
            bool isEndWave = false;
            while (true)
            {
                float random = Random.Range(_minPositionY + _step, _maxPositionY);
                _isMoving = true;
                if (!isEndWave)
                {
                    Vector3 move = new Vector3(
                        _transform.position.x,
                        _transform.position.y + _step * _speed * Time.fixedDeltaTime,
                        _transform.position.z
                    );
                    _rb.MovePosition(move);
                    if (_transform.position.y > random)
                        isEndWave = true;
                }
                else if (isEndWave)
                {
                    Vector3 move = new Vector3(
                        _transform.position.x,
                        _transform.position.y - _step * _speed * Time.fixedDeltaTime,
                        _transform.position.z
                    );
                    _rb.MovePosition(move);
                    if (_transform.position.y < _minPositionY)
                        isEndWave = false;
                }
                yield return _wait;
            }
        }
    }

    private IEnumerator UpToMaxHeight()
    {
        while (_transform.position.y < _maxPositionY)
        {
            _isMoving = true;
            Vector3 move = new Vector3(
                _transform.position.x,
                _transform.position.y + _step * _speed * Time.fixedDeltaTime,
                _transform.position.z
            );
            _rb.MovePosition(move);
            yield return _wait;
        }
        _isMoving = false;
    }

    private IEnumerator DownToMinHeight()
    {
        while (_transform.position.y > _minPositionY)
        {
            _isMoving = true;
            Vector3 move = new Vector3(
                _transform.position.x,
                _transform.position.y - _step * _speed * Time.fixedDeltaTime,
                _transform.position.z
            );
            _rb.MovePosition(move);
            yield return _wait;
        }
        _isMoving = false;
        if (_transform.position.y != _minPositionY)
        {
            Vector3 move = new Vector3(
                _transform.position.x,
                _minPositionY,
                _transform.position.z
            );
            _rb.MovePosition(move);
        }
    }

    private IEnumerator UpToRandomHeight()
    {
        if (_transform.position.y == _minPositionY)
        {
            var random = Random.Range(_minPositionY, _maxPositionY);
            while (_transform.position.y < random)
            {
                _isMoving = true;
                Vector3 move = new Vector3(
                    _transform.position.x,
                    _transform.position.y + _step * _speed * Time.fixedDeltaTime,
                    _transform.position.z
                );
                _rb.MovePosition(move);
                yield return _wait;
            }
            _isMoving = false;
        }
    }

    public void GoUpMaxHeight()
    {
        if (!_isMoving)
            StartCoroutine(UpToMaxHeight());
    }

    public void GoDownMinHeight()
    {
        if (!_isMoving)
            StartCoroutine(DownToMinHeight());
    }

    public void GoUpRandomHeight()
    {
        if (!_isMoving)
            StartCoroutine(UpToRandomHeight());
    }

    public void BackToDefaultPosition()
    {
        StopAllCoroutines();
        StartCoroutine(DownToMinHeight());
    }
}
