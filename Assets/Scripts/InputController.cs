using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour, IDisable
{
    [SerializeField] private Camera _characterCamera;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _graundCheckRadius;
    [SerializeField] private LayerMask _whatIsGround;

    private List<Cell> _cells;
    private SimpleControls _controls;
    private float _moveSpeed = 10f;
    private Vector2 _rotationCamera;
    private Vector2 _rotation;

    private void Awake()
    {
        _controls = new SimpleControls();

        _controls.gameplay.defaultAllCells.performed += context => ToDefaultCellsPosition();
        _controls.gameplay.allCellsUp.performed += context => ToRandomCellsPosition();
        _controls.gameplay.oneRandomCellUp.performed += context => ToUpRandomCellPosition();
        _controls.gameplay.oneRandomCellDown.performed += context => ToDownRandomCellPosition();
        _controls.gameplay.jump.performed += context => Jump();

        _rotation.y = transform.localEulerAngles.y;
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void Update()
    {
        var look = _controls.gameplay.look.ReadValue<Vector2>();
        Look(look);
    }

    private void FixedUpdate()
    {
        var move = _controls.gameplay.move.ReadValue<Vector2>();
        Move(move);
    }

    public void Init(List<Cell> cells)
    {
        _cells = cells;
    }

    public void Disable()
    {
        this.OnDisable();
    }

    private void Move(Vector2 direction)
    {
        if (direction.sqrMagnitude < 0.01)
            return;
        var scaledMoveSpeed = _moveSpeed * Time.deltaTime;
        var move = Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(direction.x, 0, direction.y);
        //transform.position += move * scaledMoveSpeed;
        //_rb?.AddForce(move * scaledMoveSpeed, ForceMode.VelocityChange);
        //_rb?.MovePosition(rb.position + move * scaledMoveSpeed);
        _rb?.MovePosition(transform.position + move * scaledMoveSpeed);
    }

    private void Look(Vector2 rotate)
    {
        if (rotate.sqrMagnitude < 0.01)
            return;
        var scaledRotateSpeed = _rotateSpeed * Time.deltaTime;
        _rotation.y += rotate.x * scaledRotateSpeed;
        _rotationCamera.x = Mathf.Clamp(_rotationCamera.x - rotate.y * scaledRotateSpeed, -89, 89);
        transform.localEulerAngles = _rotation;
        _characterCamera.transform.localEulerAngles = _rotationCamera;
    }

    private void Jump()
    {
        Collider[] colliders = Physics.OverlapSphere(_groundCheck.transform.position, _graundCheckRadius, _whatIsGround);
        if (colliders.Length > 0)
            _rb?.AddForce(Vector3.up * _jumpForce * Time.fixedDeltaTime, ForceMode.Impulse);
    }

    private void ToUpRandomCellPosition()
    {
        var r = Random.Range(0, _cells.Count);
        _cells[r].GoUpMaxHeight();
    }

    private void ToDownRandomCellPosition()
    {
        var r = Random.Range(0, _cells.Count);
        _cells[r].GoDownMinHeight();
    }

    private void ToDefaultCellsPosition()
    {
        foreach (var cell in _cells)
        {
            cell.BackToDefaultPosition();
        }
    }

    private void ToRandomCellsPosition()
    {
        foreach (var cell in _cells)
        {
            cell.GoUpRandomHeight();
        }
    }
}
