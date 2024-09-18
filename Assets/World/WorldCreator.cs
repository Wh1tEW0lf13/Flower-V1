using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreator : MonoBehaviour
{
    [SerializeField]
    private GameObject ground;
    public void CreateGrid(int xSize, int ySize)
    {
        for(int i = 0; i<xSize; i++)
        {
            for(int j = 0; j<ySize; j++)
            {
                var grid = Instantiate(ground,new Vector2(i,j), Quaternion.identity);
                grid.name = "Ground" + i + "," + j;
            }
        }
    }
}
