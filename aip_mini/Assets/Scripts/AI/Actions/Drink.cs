using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class Drink : ActionBase
{

    public override void Execute(IAIContext context)
    {

        var c = (Context)context;

        var player = c.self;
        //Debug.Log("Drinking " + c.time);
        //change UI text
        player.GetComponent<Player>().SetActionText("Drinking");

        player.GetComponent<Player>().SetLastDrinkTime(c.time);

        int money = player.GetComponent<Player>().GetMoneyAmount() - 1;

        player.GetComponent<Player>().SetMoneyAmount(money);

        //check where the player is
        //if not at cafe, then go to cafe
        if (!player.GetComponent<Player>().IsAtCafe())
        {
            player.GetComponent<Player>().GoToCafe();
        }



    }
}
