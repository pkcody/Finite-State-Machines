using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingPlayerState : IPlayerState
{
    public void Enter(Player player)
    {
        player.currentState = this;
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // transition to jump
            JumpingPlayerState JUMPstate = new JumpingPlayerState();
            JUMPstate.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            // transition to duck
            DuckingPlayerState DUCKState = new DuckingPlayerState();
            DUCKState.Enter(player);
        }
        if (Input.GetKey(KeyCode.B))
        {
            // center
            CenterPlayerState CENTERstate = new CenterPlayerState();
            CENTERstate.Enter(player);
        }
        if (Input.GetKey(KeyCode.M))
        {
            CopyPlayerState COPYstate = new CopyPlayerState(player);
            COPYstate.Enter(player);
        }
    }
}
