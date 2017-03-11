using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class MoneyToParty : ContextualScorerBase
{

    public override float Score(IAIContext context)
    {
        var c = (Context)context;
        var player = c.self;

        int money_amount = player.GetComponent<Player>().GetMoneyAmount();

        return money_amount >= this.score ? this.score : 0f;
    }
}
