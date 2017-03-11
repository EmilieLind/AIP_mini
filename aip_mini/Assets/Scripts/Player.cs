using System;
using System.Collections;
using Apex.AI;
using Apex.AI.Components;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour, IContextProvider
{
    private int last_meal;
    private int last_drink_time;
    private int last_party_time;
    private int money_amount = 5;

    private bool amGoingToCafe = false;
    private bool amGoingHome = false;
    private bool amGoingToWork = false;
    private bool amGoingToBar = false;

    private float speed = 5f;
    

    Vector3 atCafe = new Vector3(-1, 1, 0);
    Vector3 atHome = new Vector3(-1, -1, 0);
    Vector3 atWork = new Vector3(1, -1, 0);
    Vector3 atBar = new Vector3(1, 1, 0);

    public Text action_text;
    public Text time_text;
    public Text hunger_text;
    public Text thirst_text;
    public Text money_amount_text;
    public Text people_at_bar_text;
    public Text party_urge_text;

    private IAIContext _context;

    public void Update()
    {
        amGoingToCafe = DoSomething(amGoingToCafe, atCafe);
        amGoingHome = DoSomething(amGoingHome, atHome);
        amGoingToWork = DoSomething(amGoingToWork, atWork);
        amGoingToBar = DoSomething(amGoingToBar, atBar);

    }

    
    private bool DoSomething(bool amGoingToAPlace, Vector3 place)
    {
        if (amGoingToAPlace)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, place, step);
            if (transform.position == place)
                amGoingToAPlace = false;
        }

        return amGoingToAPlace;
    }
    

    public void GoHome()
    {
        amGoingHome = true;
    }

    public bool IsHome()
    {
        if (transform.position == atHome)
            return true;

        return false;
    }

    public void GoToCafe()
    {
        amGoingToCafe = true;
    }

    public bool IsAtCafe()
    {
        if (transform.position == atCafe)
            return true;
        
        return false;
    }

    public void GoToWork()
    {
        amGoingToWork = true;
    }

    public bool IsAtWork()
    {
        if (transform.position == atWork)
            return true;

        return false;
    }

    public void GoToBar()
    {
        amGoingToBar = true;
    }

    public bool IsAtBar()
    {
        if (transform.position == atBar)
            return true;

        return false;
    }

    public int GetMoneyAmount()
    {
        return money_amount;
    }

    public void SetMoneyAmount(int i)
    {
        money_amount = i;
        money_amount_text.text = "Money left: " + i.ToString();
    }

    public void SetThirstLevel(string s)
    {
        thirst_text.text = "Thirst: " + s;
    }

    public void SetHungerLevel(string s)
    {
        hunger_text.text = "Hunger: " + s;
    }

    public int GetLastDrinkTime()
    {
        return last_drink_time;
    }

    public void SetLastDrinkTime(int i)
    {
        last_drink_time = i;
    }

    public int GetLastMeal()
    {
        return last_meal;
    }

    public void SetLastMeal(int i)
    {
        last_meal = i;
    }

    public int GetLastPartyTime()
    {
        return last_party_time;
    }

    public void SetLastPartyTime(int i)
    {
        last_party_time = i;
    }

    public void SetPartyUrge(string i)
    {
        party_urge_text.text = "Urge to party: " + i;
    }

    public void SetPeopleAtBar(string s)
    {
        people_at_bar_text.text = "People at the bar: " + s;
    }

    public void SetTimeText(string s)
    {
        time_text.text = "Time passed: " + s;
    }

    public void SetActionText(string s)
    {
        action_text.text = "Action: " + s;
    }

    private void Awake()
    {
        _context = new Context(this.gameObject);
    }

    public IAIContext GetContext(Guid aiId)
    {
        return _context;
    }

}
