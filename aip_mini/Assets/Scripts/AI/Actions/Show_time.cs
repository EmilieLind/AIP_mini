using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class show_time : ActionBase
{
    public override void Execute(IAIContext context)
    {
        var c = (Context)context;

        var player = c.self;
       
        
        c.time++;
          
        //change UI text
        player.GetComponent<Player>().SetTimeText(c.time.ToString());
        

       
    }
}
