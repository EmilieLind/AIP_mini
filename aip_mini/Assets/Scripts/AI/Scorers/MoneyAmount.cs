using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class MoneyAmount : ContextualScorerBase
{

    public override float Score(IAIContext context)
    {
        var c = (Context)context;
        var player = c.self;

        int money_amount = player.GetComponent<Player>().GetMoneyAmount();

        return money_amount >= this.score * 1.5 ? 0f : this.score - money_amount;

    }
}
