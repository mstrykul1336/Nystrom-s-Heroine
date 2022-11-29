using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoppingPlayerState : IPlayerState
{
    Player mplayer;
    Rigidbody rbPlayer;
   
    public void Enter(Player player)
    {
        Debug.Log("Entering State: Stopping");
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.velocity = Vector3.zero;
        player.mCurrentState = this;

    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }

    }
}
