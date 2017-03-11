using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class EarnMoney : ActionBase
{

    public override void Execute(IAIContext context)
    {
        var c = (Context)context;

        var player = c.self;

        int money_amount = player.GetComponent<Player>().GetMoneyAmount();

        player.GetComponent<Player>().SetMoneyAmount(money_amount + 5);

        //TODO: increase thirst and hunger

        player.GetComponent<Player>().SetActionText("Working");

        if (!player.GetComponent<Player>().IsAtWork())
        {
            player.GetComponent<Player>().GoToWork();
        }
    }
}
