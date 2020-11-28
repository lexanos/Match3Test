using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int GridSizeHorizontal = 6;
    public int GridSizeVertical = 6;

    public GameObject TilePrefab;

    private BackgroundTile[,] allTiles;

    private void Start()
    {
        allTiles = new BackgroundTile[GridSizeHorizontal, GridSizeVertical];
        Initialize();
    }

    private void Initialize()
    {
        for (int i =0; i < GridSizeHorizontal;i++)
        {
            for (int j=0;j<GridSizeVertical;j++)
            {
                Vector2 position = new Vector2(i, j);
                GameObject go = Instantiate(TilePrefab, position, Quaternion.identity);
                go.transform.parent = this.transform;
                go.name = "(" + i + "-" + j + ")";
            }
        }
    }
}
