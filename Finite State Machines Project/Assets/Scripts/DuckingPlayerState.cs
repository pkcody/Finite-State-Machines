using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingPlayerState : IPlayerState
{
    Player mPlayer;
    Rigidbody rb;
    Vector3 changeScale;
    public void Enter(Player player)
    {
        rb = player.GetComponent<Rigidbody>();
        player.currentState = this;

        changeScale = new Vector3(2, (float)0.5, 2);
        rb.transform.localScale += changeScale; 
    }

    public void Execute(Player player)
    {
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            changeScale = new Vector3(1, 1, 1);
            rb.transform.localScale = changeScale;
            StandingPlayerState STANDstate = new StandingPlayerState();
            STANDstate.Enter(player);
        }
        if (Input.GetKey(KeyCode.C))
        {
            changeScale = new Vector3(1, 1, 1);
            rb.transform.localScale = changeScale;
            // color change
            ColorPlayerState COLORstate = new ColorPlayerState();
            COLORstate.Enter(player);
            //Debug.Log("color change");
        }
    }
}
