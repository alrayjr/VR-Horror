using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleTextVisibility : MonoBehaviour
{
    public TextMeshProUGUI textMeshProText; // Reference to the TMP Text component
    public Button button; // Reference to the Button component

    public string newText = "How Dare you click that button";

    private bool isTextVisible = false;

    void Start()
    {
        // Add a listener to the button's onClick event
        button.onClick.AddListener(ToggleText);
    }

    void ToggleText()
    {
        if (!isTextVisible)
        {
            // Set text content
            textMeshProText.text = newText;
            // Show the text
            textMeshProText.gameObject.SetActive(true);
        }
        else
        {
            // Hide the text
            textMeshProText.gameObject.SetActive(false);
        }

        // Toggle the visibility state
        isTextVisible = !isTextVisible;
    }
}

