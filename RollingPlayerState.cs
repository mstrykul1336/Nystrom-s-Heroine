using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingPlayerState : IPlayerState
{
    Player mplayer;
    Rigidbody rbPlayer;
    public void Enter(Player player)
    {
        Debug.Log("Entering State: Rolling");
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.AddForce(0,0,-10,ForceMode.VelocityChange);
        player.mCurrentState = this;

    }

    public void Execute(Player player)
    {
        //standing again
        if (Input.GetKeyDown(KeyCode.S))
        {
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }
        //stopping
        if (Input.GetKeyDown(KeyCode.X))
        {
            
            StoppingPlayerState stopState = new StoppingPlayerState();
            stopState.Enter(player);
        }

    }
}