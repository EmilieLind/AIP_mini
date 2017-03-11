using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;

public class BarPeople : ActionBase
{

    public override void Execute(IAIContext context)
    {
        var c = (Context)context;

        var player = c.self;
        System.Random rnd = new System.Random();

        if (c.time % 5 == 0)
        {
            int number_of_people = rnd.Next(0, 6);
            c.people_at_bar = number_of_people;
            player.GetComponent<Player>().SetPeopleAtBar(c.people_at_bar.ToString());
            //Debug.Log("Changed number of people to " + c.people_at_bar + " at time " + c.time);
        }
    }
}
