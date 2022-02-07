using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private PlayingField _fieldPrefab;
    [SerializeField] private InputController _playerInputPrefab;
    [SerializeField] private Camera _mainCameraPrefab;
    [SerializeField] private Finish _finishPrefab;
    [SerializeField] private int _rowsCount;

    private PlayingField _field;
    private Camera _mainCamera;
    private InputController _playerInput;
    private Finish _finish;

    private void Awake()
    {
        _field = Instantiate(_fieldPrefab);
        _field.Init(_rowsCount);

        Vector3 cameraPos = new Vector3(
            0,
            200,
            -200
        );
        _mainCamera = Instantiate(_mainCameraPrefab, cameraPos, Quaternion.identity);
        _mainCamera.TryGetComponent(out GeneralCamera camera);
        camera?.Init(_field.transform, new Vector3(0f, 200f, -200f));

        Vector3 playerPos = new Vector3(
            _field.FirstCell.transform.position.x,
            _field.FirstCell.transform.position.y + (_field.FirstCell.transform.localScale.y / 2) + Vector3.up.y,
            _field.FirstCell.transform.position.z
        );
        _playerInput = Instantiate(_playerInputPrefab, playerPos, Quaternion.LookRotation(_field.LastCell.transform.position));
        _playerInput.TryGetComponent(out InputController inputController);
        inputController?.Init(_field.Cells);

        Vector3 finishPosition = new Vector3(
            _field.LastCell.transform.position.x,
            _field.LastCell.transform.position.y,
            _field.LastCell.transform.position.z
        );
        _finish = Instantiate(_finishPrefab, finishPosition, _field.LastCell.transform.rotation);
    }
}
