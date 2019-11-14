using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class testing : MonoBehaviour
{

    private Grid grid;
    // Start is called before the first frame update
    private void Start()
    {
        grid = new Grid(20, 10, 20f, new Vector3(20, 0, 0));
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));


        }
    }
}