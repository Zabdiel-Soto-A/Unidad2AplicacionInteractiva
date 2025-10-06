using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collision : MonoBehaviour
{
    public TextMeshProUGUI buttonText; // Or public Text buttonText; for regular UI Text
    public TMP_FontAsset font1; // Or public Font font1;
    public TMP_FontAsset font2; // Or public Font font2;

    private bool isFont1Active = true;
    void OnTriggerEnter2D (Collider2D coll) {
        Debug.Log("Collition detected");

        if (isFont1Active)
        {
            buttonText.font = font2;
        }
        else
        {
            buttonText.font = font1;
        }
        isFont1Active = !isFont1Active; // Toggle the state
    }
}
