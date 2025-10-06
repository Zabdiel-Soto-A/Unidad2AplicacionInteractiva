using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CollChar2 : MonoBehaviour
{
    Animator character2_Animator;
    GameObject character;
    GameObject[] char2;
    void Awake()
    {
        char2 = GameObject.FindGameObjectsWithTag("Char2");
    }

    void OnTriggerEnter2D(Collider2D coll2)
    {
        Debug.Log("Collition detected");

        foreach (GameObject character in char2)
        {
            character2_Animator = character.GetComponent<Animator>();
            character2_Animator.SetBool("IsActive", true);
        }
    }

    void OnTriggerExit2D(Collider2D collider2)
    {
        foreach (GameObject character in char2)
        {
            character2_Animator = character.GetComponent<Animator>();
            character2_Animator.SetBool("IsActive", false);
        }
    }
}

