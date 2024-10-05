using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreator : MonoBehaviour
{
    [SerializeField]
    private GameObject ground, water;
    [SerializeField]
    private GameObject[] resources;
    int c, startPosition;
    public void CreateGrid(int xSize, int ySize, int riverSize, int resNumber)
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
        startPosition = Random.Range(1, xSize - 1);
        WaterCreator(xSize, ySize, upOrLeft, riverSize);
        for(int i = 0; i<resources.Length; i++)
        {
            ResSpawner(xSize, ySize, resNumber, resources[i]);
        }
        
    }

    void ResSpawner(int xSize, int ySize, int resNumber, GameObject res)
    {
        for (int i = 0; i < resNumber; i++)
        {
            Vector2 pos = new Vector2(Random.Range(1, xSize), Random.Range(1, ySize));
            GameObject resName = Instantiate(res, pos, Quaternion.identity);
            resName.name = res.name;
        }
    }
    ////////////////////////////////////////////////////////////////////////////// Water Creator
    public void WaterCreator(int xSize, int ySize, int upOrLeft, int riverSize)
    {
        int j = 0;
        if (upOrLeft == 0)
        {
            while(j<ySize)
            {
                Border(xSize);
                for (int i = startPosition; i < startPosition + riverSize; i++)
                {  
                    Destroy(GameObject.Find("Ground" + i + "," + j));
                    var blue = Instantiate(water, new Vector2(i, j), Quaternion.identity);
                    blue.name = "Water" + i + "," + j;  
                }
                j++;
            } 
        }
        else
        {
            while (j < xSize)
            {
                Border(ySize);
                for (int i = startPosition; i < startPosition + riverSize; i++)
                {
                    Destroy(GameObject.Find("Ground" + j + "," + i));
                    var blue = Instantiate(water, new Vector2(j, i), Quaternion.identity);
                    blue.name = "Water" + j + "," + i;
                }
                j++;
            }
        }
           
    }
    private int Curve()
    {
        switch(Random.Range(0,101))
        {
            case int i when i >= 0 && i<70:
                return 0;
            case int i when i >= 70 && i < 85:
                return 1;
            default:
                return -1;
        }
    }

    private void Border(int end)
    {
        c = Curve();
        startPosition += c;
        if (startPosition <= 0)
        {
            startPosition = 1;
        }
        else if (startPosition >= end - 2)
        {
            startPosition = end;
        }
    }
    /////////////////////////////////////////////////////////////////// End of Water Creator
}
