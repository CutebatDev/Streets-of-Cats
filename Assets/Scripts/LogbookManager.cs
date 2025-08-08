using System;
using UnityEngine;

public class LogbookManager : MonoBehaviour
{
    
    public GameObject itemContainer;
    private bool isItemsContainerActive = false;
    
    void Start()
    {
        HideContainer();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isItemsContainerActive) {
                HideContainer();
            }
            else {
                ShowContainer();
            }
        }    
    }


    public void ShowContainer()
    {
        isItemsContainerActive = true;
        itemContainer.SetActive(isItemsContainerActive);
        // Can later add cool animations like a move from right to the anchors which can be really cool and awesome
    }

    public void HideContainer()
    {
        isItemsContainerActive = false;
        itemContainer.SetActive(isItemsContainerActive);
    }
    
}
