using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private float starterScale, starterPosition, position;
    [SerializeField]
    private GameObject greenBar, rock;
    Mineable mineable;
    private void Start()
    {
        mineable = rock.GetComponent<Mineable>();
        gameObject.SetActive(false);
    }
    public void Border()
    {
        position = (float) mineable.hp / mineable.maxHp;
        greenBar.transform.localScale = new Vector3(position, greenBar.transform.localScale.y); //Set green bar to get shorter.
        greenBar.transform.localPosition = new Vector2((1 - position) / 2f, greenBar.transform.localPosition.y);
    }

    public void BarActive()
    {
        if(gameObject.activeSelf==false)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false); //Set healthbar to invisible
        }
        
    }
}
