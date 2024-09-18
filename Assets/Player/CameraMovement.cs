using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    private readonly float scrollSpeed = 2000f;
    private Vector3 pos;
    private float scroll;
    void Update()
    {
        pos.x = player.transform.position.x;
        pos.y = player.transform.position.y;
        scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.z += scroll * scrollSpeed * Time.deltaTime;
        pos.z = Mathf.Clamp(pos.z, -25f, -5f);
        transform.position = pos;
    }


}
