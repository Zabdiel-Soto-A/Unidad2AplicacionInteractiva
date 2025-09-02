using UnityEngine;

public class LinkYoutube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnButtonClick()
    {
        Debug.Log("Button was clicked!");
        // Add any desired functionality here
        Application.OpenURL("https://www.youtube.com");
    }
}
