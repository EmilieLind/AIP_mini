using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class DrinkingBuddies : ContextualScorerBase
{

    public override float Score(IAIContext context)
    {
        var c = (Context)context;
        var player = c.self;

        int buddies = c.people_at_bar;

        return c.people_at_bar > this.score ? this.score : 0f;
    }
}
