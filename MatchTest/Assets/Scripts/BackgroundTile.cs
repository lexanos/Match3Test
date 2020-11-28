using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTile : MonoBehaviour
{
    public GameObject[] Figures;

    private void Start()
    {
        Initialize();
    }
    private void Initialize()
    {
        int randomFigure = Random.Range(0, Figures.Length);
        GameObject go = Instantiate(Figures[randomFigure], transform.position, Quaternion.identity);
        go.transform.parent = this.transform;
        go.name = this.gameObject.name;
    }
}
