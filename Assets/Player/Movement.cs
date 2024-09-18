using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    private float moveSpeed;
    [SerializeField]
    private float walk, sprint;
    Quaternion num;
    private void Start()
    {
        num = new Quaternion(0, 0, 0, 0);
    }
    void Update()
    {
        Move();
        transform.rotation = num;
    }

    void Move()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = sprint;
        }
        else
        {
            moveSpeed = walk;
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(moveSpeed * Time.deltaTime * Vector2.up);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(moveSpeed * Time.deltaTime * Vector2.down);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(moveSpeed * Time.deltaTime * Vector2.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpeed * Time.deltaTime * Vector2.right);
        }
    }
}
