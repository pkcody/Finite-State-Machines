using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivingPlayerState : IPlayerState
{
    Player mPlayer;
    Rigidbody rb;
    float time;

    public void Enter(Player player)
    {
        rb = player.GetComponent<Rigidbody>();
        player.currentState = this;

        rb.AddForce(0, -10000 * Time.deltaTime, 0, ForceMode.VelocityChange);
    }

    public void Execute(Player player)
    {
        if (Physics.Raycast(rb.transform.position, Vector3.down, .55f))
        {
            IPlayerState runState;
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                // transition to duck
                runState = new DuckingPlayerState();
                //DUCKState.Enter(player);
            }
            else
            {
                // transition to jump
                runState = new StandingPlayerState();
                //JUMPstate.Enter(player) = runState;
            }
            runState.Enter(player);
        }
    }
}
