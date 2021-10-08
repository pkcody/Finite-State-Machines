using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPlayerState : IPlayerState
{

    Player mPlayer;
    Rigidbody rb;
    public Material playerMat;

    public void Enter(Player player)
    {
        rb = player.GetComponent<Rigidbody>();
        player.currentState = this;
        MeshRenderer meshRenderer = player.GetComponent<MeshRenderer>();

        player.colorNum++;
        //Debug.Log(player.colorNum);
        if (player.colorNum > 6)
            player.colorNum = 1;

        if (player.colorNum == 1)
            meshRenderer.material.color = Color.red;
        if (player.colorNum == 2)
            meshRenderer.material.color = Color.green;
        if (player.colorNum == 3)
            meshRenderer.material.color = Color.blue;
        if (player.colorNum == 4)
            meshRenderer.material.color = Color.black;
        if (player.colorNum == 5)
            meshRenderer.material.color = Color.cyan;
        if (player.colorNum == 6)
            meshRenderer.material.color = Color.magenta;
    }

    public void Execute(Player player)
    {
        if (!Input.GetKey(KeyCode.S))
        {
            StandingPlayerState STANDstate = new StandingPlayerState();
            STANDstate.Enter(player);
        }
        if (!Input.GetKey(KeyCode.B))
        {
            CenterPlayerState CENTERstate = new CenterPlayerState();
            CENTERstate.Enter(player);
        }
    }
}
