using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class PartyItch : ContextualScorerBase
{

    public override float Score(IAIContext context)
    {
        var c = (Context)context;
        var player = c.self;

        float time_since_last_party = c.time - player.GetComponent<Player>().GetLastPartyTime();

        float party_urge = Mathf.Max(0f, time_since_last_party - this.score);

        player.GetComponent<Player>().SetPartyUrge(party_urge.ToString());

        return party_urge;
    }
}
