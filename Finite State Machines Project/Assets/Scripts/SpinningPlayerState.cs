using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPlayerState : IPlayerState
{
    float x;
    float z;
    float rotationSpeed = 360f;
    Player mPlayer;
    Rigidbody rb;
    float time;

    public void Enter(Player player)
    {
        rb = player.GetComponent<Rigidbody>();
        player.currentState = this;
        

        //rb.transform.localRotation = Quaternion.Euler(x,0,z);
        //player.transform.Rotate(0f, 360 * z, 0f);
    }

    public void Execute(Player player)
    {
        z = Time.deltaTime * rotationSpeed;
        player.transform.Rotate(0f, 360 * z, 0f);
        if (!Input.GetKey(KeyCode.S))
        {
            StandingPlayerState STANDstate = new StandingPlayerState();
            STANDstate.Enter(player);
        }
    }
}
