using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RockResources : Mineable
{
    private void Start()
    {
        hp = maxHp = 15;
        RandomQuantity();   //Set textmeshpro + set quantity of a material
        resName = "Rock";
    }
    
}
