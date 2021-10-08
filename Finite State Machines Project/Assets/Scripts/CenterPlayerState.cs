using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterPlayerState : IPlayerState
{
    Player mPlayer;
    Rigidbody rb;
    Vector3 changePos;
    public void Enter(Player player)
    {
        rb = player.GetComponent<Rigidbody>();
        player.currentState = this;

        //changePos = new Vector3(2, (float)0.5, 2);
        rb.transform.position = new Vector3(0,1,0);
        Debug.Log("center");
    }

    public void Execute(Player player)
    {
        if (!Input.GetKey(KeyCode.B))
        {
            StandingPlayerState STANDstate = new StandingPlayerState();
            STANDstate.Enter(player);
        }
    }
}
