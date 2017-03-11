using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class Rest : ActionBase
{
    public override void Execute(IAIContext context)
    {

        var c = (Context)context;

        var player = c.self;

        //Debug.Log("Resting " + c.time);
        //change UI text
        player.GetComponent<Player>().SetActionText("Resting");


        //check where the player is
        //if not home, then go home
        if (!player.GetComponent<Player>().IsHome())
        {
            player.GetComponent<Player>().GoHome();
        }


    }
}
