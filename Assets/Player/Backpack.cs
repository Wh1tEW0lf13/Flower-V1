using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    private int rock;
    private int wood;

    public void AddResources(string res)
    {
        Debug.Log(res);
        switch(res)
        {
            case "Rock":
                {
                    rock++;
                    break;
                }
            case "Wood":
                {
                    wood++;
                    break;
                }
        }
    }
    
}
