using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Extraction : MonoBehaviour
{
    private RockResources rock;
    private GameObject res; //Mineable resources
    [SerializeField]
    private GameObject pickaxe;
    public bool pickaxeInHand = false;

    private void Start()
    {
        pickaxe.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0)&&res!=null)
        {
            rock.Mining();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))   //if press 1, pickaxe draw out or pocket;
        {
            PickaxeDrawOut();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        res = collision.gameObject;
        rock = res.GetComponent<RockResources>();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        res = null;
    }
    private void PickaxeDrawOut()
    {
        if (pickaxe.activeSelf == true)
        {
            pickaxe.SetActive(false);
            pickaxeInHand = false;
        }
        else
        {
            pickaxeInHand = true;
            pickaxe.SetActive(true); //psuh
        }
    }
}
