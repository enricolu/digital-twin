using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap : MonoBehaviour
{
    private int width;
    private int height;
    private int[,] gridArray;
    // Start is called before the first frame update
    public GridMap(int width, int height)
    {
        this.width = width;
        this.height = height;

        gridArray = new int[width, height];

        Debug.Log(width + " " + height);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
