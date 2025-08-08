using TMPro;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    public int currentDay = 0;
    
    private Animator animator;
    public TextMeshProUGUI dayTextLabel;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        NextDay();
    }

    void Update() { if (Input.GetKeyDown(KeyCode.Tab)) NextDay(); }
    
    
    public void NextDay()
    {
        currentDay++;
        dayTextLabel.text = "Day " + currentDay.ToString();
        animator.SetTrigger("Next Day");
        
        // TODO - 
        // Connect to CatManager
        // Increase Hunger and Water need
        // Call EventManager to give next event
        // Build the logbook text and functionality
        
        // But hey at least we have the cool animation
    }
}
