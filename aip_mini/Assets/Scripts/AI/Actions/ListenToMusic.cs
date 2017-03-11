using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class ListenToMusic : ActionBase
{

    public override void Execute(IAIContext context)
    {
        var c = (Context)context;

        var player = c.self;

        player.GetComponent<Player>().SetActionText("Listening to music");

        //check where the player is
        //if not at bar, then go to bar
        if (!player.GetComponent<Player>().IsAtBar())
        {
            player.GetComponent<Player>().GoToBar();
        }

        player.GetComponent<Player>().SetLastPartyTime(c.time);

        int money_amount = player.GetComponent<Player>().GetMoneyAmount() - 3;

        player.GetComponent<Player>().SetMoneyAmount(money_amount);
    }
}
