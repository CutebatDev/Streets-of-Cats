using System.Collections.Generic;
using UnityEngine;

public class GameEventManager : MonoBehaviour
{
    public LogbookManager logbook; // Display the options to the logbook

    public List<Event> previousEvents = new List<Event>();
    public Event[][] events;
    // Every day has an array of different events
    // At the start of the day choose on event from those different options
    // Events are rolled every day and certain events could maybe lead to other events in the future
    // if (previousEvents.has(option1)) { }

    public Event currentEvent;
    
    void Awake()
    {
        Event susman2 = new Event("Suspicious man 2",
            "A very sus man approaches you again but this time its also again...", new Option[] { });
        
        events = new Event[][]
        {
            new Event[] { new Event("Rain!","It's a rainpour! Whatever will we do?",new Option[]{}) },
            new Event[] {
                new Event("Fight!","Garfield and Mitzi are fighting!",new Option[]{}),
                new Event("Suspicious man 1","A shadowy figure approaches", new Option[] {
                    new Option("Attack","Person walks away",susman2) }),
                new Event("Rumors of Tuna","Some cats in the streets have been talking about some possible tuna" +
                        ", but the neighbourhood is a bit shady",new Option[]{}),
            }
        }; 
    }
    
    
    
    
    public class Event
    {
        public string eventName { get; private set; }
        public string description { get; private set; }
        
        // Possible events that are connected to this one - can create a storyline  
        public Option[] options { get; private set; }
        
        public Event(string eventName, string description, Option[] options)
        {
            this.eventName = eventName;
            this.description = description;
            this.options = options;
        }
    }

    public class Option
    {
        public string optionName { get; private set; }
        public string optionDescription { get; private set; }
        public Event leadingEvent { get; private set; }
            
        // TODO :
        // Decide on how to implement the outcome system
        // If decided option x then give +2 cat food -1 water
        // Maybe roll for different options based on chance or previous choices
        
        public Option(string optionName, string optionDescription, Event leadingEvent)
        {
            this.optionName = optionName;
            this.optionDescription = optionDescription;
            this.leadingEvent = leadingEvent;
        }
    }
    
}
