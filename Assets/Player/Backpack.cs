using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    [SerializeField]
    private int rock, wood;

    public void AddResources(string res)
    {
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
