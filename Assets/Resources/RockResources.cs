using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RockResources : Mineable
{
    
    private void Start()
    {
        hp = maxHp = 10;
        RandomQuantity();   //Set textmeshpro + set quantity of a material
        resName = "Rock";
    }
    public void Mining()
    {
        extraction = player.GetComponent<Extraction>();
        if (extraction.pickaxeInHand == true)
        {
            hp--;
            textMesh.SetText(hp.ToString() + "/" + maxHp.ToString());
            HealthCheck();     //Checking if hp low down to 0.
        }
        else
        {
            Debug.Log(playerInfo.playerHealth);
            playerInfo.PainMaker();
        }
            
    }
}
