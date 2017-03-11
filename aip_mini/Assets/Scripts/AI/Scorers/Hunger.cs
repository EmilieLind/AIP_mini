using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public sealed class Hunger : ContextualScorerBase
{

    public override float Score(IAIContext context)
    {
        var c = (Context)context;
        var player = c.self;

        float time_since_last_meal = c.time - player.GetComponent<Player>().GetLastMeal();

        float hunger = Mathf.Max(0f, time_since_last_meal - this.score);

        player.GetComponent<Player>().SetHungerLevel(hunger.ToString());

        return hunger;
    }

}
