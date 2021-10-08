using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPlayerState : IPlayerState
{
    //Rigidbody rb;
    public Minion m_Minion;
    public MasterSpawner m_Spawner;
    private Master m_Spawn;
    private int m_incMinion = 0;

    public CopyPlayerState(Player player)
    {
        m_Spawner = player.gameObject.GetComponent<MasterSpawner>();
        m_Minion = player.gameObject.GetComponent<Minion>();
    }
    public void Enter(Player player)
    {
        //rb = player.GetComponent<Rigidbody>();
        player.currentState = this;

        m_Spawn = m_Spawner.SpawnMaster(m_Minion);
        m_Spawn.name = "Mionion_Clone_" + ++m_incMinion;
        m_Spawn.transform.Translate(Vector3.forward * m_incMinion * 1.5f);
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
