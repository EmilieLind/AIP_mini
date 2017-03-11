using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class Eat : ActionBase
{

    public override void Execute(IAIContext context)
    {

        var c = (Context)context;

        var player = c.self;

        //Debug.Log("Eating " + c.time);
        //change UI text
        player.GetComponent<Player>().SetActionText("Eating");

        player.GetComponent<Player>().SetLastMeal(c.time);

        int money = player.GetComponent<Player>().GetMoneyAmount() - 2;

        player.GetComponent<Player>().SetMoneyAmount(money);


        //check where the player is
        //if not at cafe, then go to cafe
        if (!player.GetComponent<Player>().IsAtCafe())
        {
            player.GetComponent<Player>().GoToCafe();
        }



    }
}
