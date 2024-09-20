using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreator : MonoBehaviour
{
    [SerializeField]
    private GameObject ground, water;
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
        int upOrLeft = Random.Range(0, 2); // From down to up if 0, or from left to right if 1
        if (upOrLeft == 0)
        {
            int startPosition = Random.Range(1, xSize - 1);
            WaterCreator(startPosition, 0);
        }
        else
        {
            int startPosition = Random.Range(1, ySize - 1);
            WaterCreator(0, startPosition);
        }
    }
    public void WaterCreator(int xSize, int ySize)
    {
        Destroy(GameObject.Find("Ground" + xSize + "," + ySize));
        var blue = Instantiate(water, new Vector2(xSize, ySize), Quaternion.identity);
        blue.name = "Water" + xSize + "," + ySize;
    }
}
