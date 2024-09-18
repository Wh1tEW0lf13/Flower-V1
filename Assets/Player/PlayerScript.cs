using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int playerHealth = 10;
    public float maxWeight = 10;

    public void PainMaker()
    {
        playerHealth--;
        if(playerHealth<=0)
        {
            Debug.Log("GameOver");
        }
    }
    public void Weight()
    {

    }
}
