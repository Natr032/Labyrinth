using System.Collections.Generic;
using UnityEngine;

public class PlayingField : MonoBehaviour
{
    [SerializeField] private Cell _cellPrefab;

    public List<Cell> Cells { get; private set; } = new List<Cell>();
    public Cell FirstCell { get; private set; }
    public Cell LastCell { get; private set; }

    private void Create(int rows)
    {
        int amount = rows * 2;
        for (int i = 0; i < amount; i++)
        {
            for (int j = 0; j < amount; j++)
            {
                var cell = Instantiate(_cellPrefab, this.transform);
                var _offset = (cell.transform.localScale.x * amount / 2) - (cell.transform.localScale.x / 2);
                Cells.Add(cell);
                cell.transform.position = new Vector3(
                    (transform.position.x + i * cell.transform.localScale.x) - _offset, 
                    transform.position.y, 
                    transform.position.z + j * cell.transform.localScale.z - _offset
                );
            }
        }

        FirstCell = Cells[0];
        LastCell = Cells[Cells.Count - 1];
    }

    public void Init(int rows)
    {
        Create(rows);
    }
}
