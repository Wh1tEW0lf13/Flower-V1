using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public abstract class Mineable : MonoBehaviour
{
    //private int resources;
    public float hp, maxHp;
    private float barPosition = 0;
    [SerializeField]
    private GameObject greenBar, healthBar;
    [SerializeField]
    protected GameObject text;
    private Backpack backpack;
    public TextMeshPro textMesh;
    protected GameObject player;
    protected Extraction extraction;
    protected PlayerScript playerInfo;
    public string resName;
    protected int RandomQuantity()
    {
        textMesh = text.GetComponent<TextMeshPro>();
        textMesh.SetText(hp.ToString() + "/" + maxHp.ToString());
        return Random.Range(5, 11);
    }
    
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            healthBar.SetActive(true);  //Set healthbar to visible 
            player = collision.gameObject;
            playerInfo = collision.GetComponent<PlayerScript>();
            backpack = player.GetComponent<Backpack>();
        }
    }
    protected void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            healthBar.SetActive(false); //Set healthbar to invisible
            player = null;
        }
    }
    public void HealthCheck()
    {
        barPosition++;
        greenBar.transform.position = new Vector2((2f/(maxHp/barPosition))+transform.position.x, transform.position.y+4);
        greenBar.transform.localScale = new Vector3(hp / maxHp, 0.25f); //Set green bar to get shorter.
        if (hp <= 0)
        {
            backpack.AddResources(resName);
            Destroy(transform.parent.gameObject);         
        }
    }
    

}
