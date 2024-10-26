using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    [SerializeField]
    private int rock, wood;

    public void AddResources(string res)    //When destroy a material, it's adding to eq
    {
        switch(res)
        {
            case "Rock":
                {
                    rock++;
                    break;
                }
            case "Tree":
                {
                    wood++;
                    break;
                }
        }
    }
    
}
