using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPlayerState : IPlayerState
{
    float x;
    float z;
    float rotationSpeed = 75f;
    Player mPlayer;
    Rigidbody rb;
    float time;

    public void Enter(Player player)
    {
        rb = player.GetComponent<Rigidbody>();
        player.currentState = this;
        z += Time.deltaTime * rotationSpeed;

        rb.transform.localRotation = Quaternion.Euler(x,0,z);
    }

    public void Execute(Player player)
    {
        if (!Input.GetKey(KeyCode.S))
        {
            StandingPlayerState STANDstate = new StandingPlayerState();
            STANDstate.Enter(player);
        }
    }
}
