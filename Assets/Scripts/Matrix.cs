using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrix : MonoBehaviour
{
    public GameObject cellModel;
    public int colCount, rowCount;

    public Color color;

    List<List<Cell>> cells = new List<List<Cell>>();

    void Start()
    {
        for (int row = 0; row < rowCount; row++)
        {
            var line = new List<Cell>();

            for (int col = 0; col < colCount; col++)
            {
                var cellGO = Instantiate(cellModel, new Vector3(col, row), Quaternion.identity, transform);
                var cell = cellGO.GetComponent<Cell>();
                cell.TurnOff();
                ChangeColor(cell);
                line.Add(cell);
            }
            cells.Add(line);
        }
    }

    void ChangeColor(Cell cell)
    {
        var r = Random.Range(0f, 1f);
        var g = Random.Range(0f, 1f);
        var b = Random.Range(0f, 1f);

        var color = new Color(r, g, b);

        cell.spriteRenderer.color = color;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var cell = GetCell(Input.mousePosition);
            if (cell != null)
            {
                cell.TurnOn();
                cell.spriteRenderer.color = color;
            }
        }

        if (Input.GetMouseButton(1))
        {
            var cell = GetCell(Input.mousePosition);
            if (cell != null)
            {
                cell.TurnOff();
            }
        }
    }

    Cell GetCell(Vector3 mousePos)
    {
        var coord = Camera.main.ScreenToWorldPoint(mousePos);
        int col = Mathf.RoundToInt(coord.x);
        int row = Mathf.RoundToInt(coord.y);

        if (col < 0 || row < 0 || col >= colCount || row >= rowCount)
        {
            return null;
        }

        var cell = cells[row][col];
        return cell;
    }
}
