using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrix : MonoBehaviour
{
    public GameObject cellModel;

    List<Cell> cells = new List<Cell>();

    void Start()
    {
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                var cellGO = Instantiate(cellModel, new Vector3(col, row), Quaternion.identity, transform);
                var cell = cellGO.GetComponent<Cell>();
                cells.Add(cell);
            }
        }

        


    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //cell.TurnOn();
        }

        if (Input.GetMouseButtonDown (1))
        {
            //cell.TurnOff();
        }
    }
}
