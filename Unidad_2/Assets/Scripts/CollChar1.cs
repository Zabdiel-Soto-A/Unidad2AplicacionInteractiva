using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CollChar1 : MonoBehaviour
{
    Animator character_Animator;
    GameObject character;
    GameObject[] char1;
    void Awake()
    {
        char1 = GameObject.FindGameObjectsWithTag("Char1");
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Collition detected");

        foreach (GameObject character in char1)
        {
            character_Animator = character.GetComponent<Animator>();
            character_Animator.SetBool("IsActive", true);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        foreach (GameObject character in char1)
        {
            character_Animator = character.GetComponent<Animator>();
            character_Animator.SetBool("IsActive", false);
        }
    }
}
