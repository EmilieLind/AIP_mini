using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class IsAtCafe : ContextualScorerBase
{

    public override float Score(IAIContext context)
    {
        var c = (Context)context;
        var player = c.self;

        return player.GetComponent<Player>().IsAtCafe() ? this.score : 0f;
    }
}
