using System.Collections.Generic;
using Apex.AI;
using UnityEngine;


public class Context : IAIContext
{

    public Context(GameObject gameObject)
    {
        this.self = gameObject;
        this.time = time;
        this.people_at_bar = people_at_bar;
    }

    public GameObject self
    {
        get;
        private set;
    }

    
    public int time
    {
        get;
        set;
    }

    public int people_at_bar
    {
        get;
        set;
    }


}
