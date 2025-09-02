using UnityEngine;

public class LinkGoogle : MonoBehaviour
{
    public void OnButtonClick()
    {
        Debug.Log("Button was clicked!");
        // Add any desired functionality here
        Application.OpenURL("https://www.google.com");
    }
}
