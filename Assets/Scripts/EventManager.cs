using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public LogbookManager logbook;
    

    public Event[][] events;

    void Awake()
    {
        // Now it's safe to use instance fields
        Event susman2 = new Event("Suspicious man 2",
            "A very sus man approaches you again but this time it's also again...",
            new Option[] { });

        events = new Event[][]
        {
            new Event[] {
                new Event("Rain!", "It's a rainpour! Whatever will we do?", new Option[] {})
            },
            new Event[]
            {
                new Event("Fight!", "Garfield and Mitzi are fighting!", new Option[]{}),
                new Event("Suspicious man 1", "A shadowy figure approaches",
                    new Option[] { new Option("Attack", "Person walks away", susman2) })
            }
        };
    }

    void Update()
    {
        // whatever your update logic is
    }

    public class Event
    {
        public string eventName { get; private set; }
        public string description { get; private set; }
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

        public Option(string optionName, string optionDescription, Event leadingEvent)
        {
            this.optionName = optionName;
            this.optionDescription = optionDescription;
            this.leadingEvent = leadingEvent;
        }
    }
}