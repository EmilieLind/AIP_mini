using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class Thirst : ContextualScorerBase
{

    public override float Score(IAIContext context)
    {
        var c = (Context)context;
        var player = c.self;

        float time_since_last_drink = c.time - player.GetComponent<Player>().GetLastDrinkTime();

        float thirst = Mathf.Max(0f, time_since_last_drink - this.score);

        player.GetComponent<Player>().SetThirstLevel(thirst.ToString());

        return thirst;
    }
}
