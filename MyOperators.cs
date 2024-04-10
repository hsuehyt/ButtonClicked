using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyOperators : MonoBehaviour
{
    private TextMeshProUGUI TextMeshPro; // Declare a private field to hold a TextMeshProUGUI component

    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>(); // Assign the TextMeshProUGUI component attached to this game object
    }

    // Update is called once per frame
    void Update()
    {
        // Currently, the Update method is empty (no code inside)
        // You can add logic here if needed for frame-by-frame updates
    }

    // Custom method to display a message
    public void DisplayMessage()
    {
        TextMeshPro.text = "Button Clicked!"; // Set the text of the TextMeshProUGUI component to "Button Clicked!"
    }
}
