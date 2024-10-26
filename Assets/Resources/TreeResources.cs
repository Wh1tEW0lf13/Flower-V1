using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeResources : Mineable
{
    private void Start()
    {
        hp = maxHp = 10;
        RandomQuantity();   //Set textmeshpro + set quantity of a material
        resName = "Tree";
    }
}
