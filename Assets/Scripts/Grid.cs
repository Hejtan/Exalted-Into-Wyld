using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Grid
{
    private int width;
    private int height;
    private int[,] gridArray;
    private float cellSize;
    private Grid(int width, int height) {
        this.width = width;
        this.height = height;
        gridArray = new int[width, height];

        // for (int i=0; i<width; i++) {
        //     for (int j=0; j<height; j++) {

        //     }
        // }
    }
    private Vector3 GetWorldPosition(int x, int y) {
        return new Vector3(x, y) * cellSize;
    }

}
