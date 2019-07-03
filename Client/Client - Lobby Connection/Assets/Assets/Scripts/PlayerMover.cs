using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMover : NetworkBehaviour
{
    [SerializeField] private float movespeed = 1f;

    private void Update()
    {
        if (isLocalPlayer)
        {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        transform.position += movement * Time.deltaTime * movespeed;

        }
    }
}
