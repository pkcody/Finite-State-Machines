using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingPlayerState : IPlayerState
{
    Rigidbody rb;
    float time;

    public void Enter(Player player)
    {
        rb = player.GetComponent<Rigidbody>();
        player.currentState = this;

        time = Time.time;
        rb.velocity = new Vector3(0, 6, 0);
    }

    public void Execute(Player player)
    {
        if (Physics.Raycast(rb.transform.position, Vector3.down, .55f) && (Time.time - time > 0.5f))
        {
            StandingPlayerState STANDstate = new StandingPlayerState();
            STANDstate.Enter(player);
        }
        if (Input.GetKey(KeyCode.S)) // spin and dive
        {
            // spin
            SpinningPlayerState SPINstate = new SpinningPlayerState();
            SPINstate.Enter(player);
            Debug.Log("Spin");
        }
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S)) // dive no spin
        {
            // Dive
            DivingPlayerState DIVEstate = new DivingPlayerState();
            DIVEstate.Enter(player);
        }
    }
}
