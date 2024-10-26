using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Extraction : MonoBehaviour
{
    private RockResources rock;
    private TreeResources tree;
    private string res; //Mineable resources
    [SerializeField]
    private GameObject pickaxe;
    public bool pickaxeInHand = false;

    private void Start()
    {
        pickaxe.SetActive(false);   //When game start, pickaxe is hidden
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && res.Length==0)  //If resources exist, and we press left mouse botton, function started;
        {
            switch(res)
                {
                case ("Rock"):
                    {
                        rock.Mining();
                        break;
                    }
                case ("Tree"):
                    {
                        tree.Mining();
                        break;
                    }
                }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))   //if press 1, pickaxe draw out or pocket;
        {
            PickaxeDrawOut();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<RockResources>(out RockResources rRes))
        {
            rock = collision.gameObject.GetComponent<RockResources>();
            res = rock.resName;
        }
        else if(collision.gameObject.TryGetComponent<TreeResources>(out TreeResources tRes))
        {
            tree = collision.gameObject.GetComponent<TreeResources>();
            res = tree.resName;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        res = "";
    }
    private void PickaxeDrawOut()   
    {
        if (pickaxe.activeSelf == true)
        {
            pickaxe.SetActive(false);
            pickaxeInHand = false;  //Resources script knows if pickaxe is in hand
        }
        else
        {
            pickaxeInHand = true;
            pickaxe.SetActive(true); 
        }
    }
}
