using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public abstract class Mineable : MonoBehaviour
{
    //private int resources;
    public float hp, maxHp;
    [SerializeField]
    protected GameObject text, health;
    private Backpack backpack;
    public TextMeshPro textMesh;
    protected GameObject player;
    protected Extraction extraction;
    protected PlayerScript playerInfo;
    public string resName;
    HealthBar healthBar;
    protected int RandomQuantity()
    {
        healthBar = health.GetComponent<HealthBar>();
        textMesh = text.GetComponent<TextMeshPro>();
        textMesh.SetText(hp.ToString() + "/" + maxHp.ToString()); //generate healthbar
        return Random.Range(5, 11);
    }
    
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            healthBar.BarActive();
            player = collision.gameObject;
            playerInfo = collision.GetComponent<PlayerScript>();
            backpack = player.GetComponent<Backpack>();
        }
        if (collision.CompareTag("Water") | collision.CompareTag("Mineable"))
        {
            Destroy(transform.parent.gameObject);
        }
    }
    protected void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            healthBar.BarActive();
            player = null;
        }
    }
    public void HealthCheck()
    {
        healthBar.Border();
        if (hp <= 0)
        {
            backpack.AddResources(resName);
            Destroy(transform.parent.gameObject);         
        }
        
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
            playerInfo.PainMaker();
        }

    }

}
