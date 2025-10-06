using UnityEngine;

public class ClickChar4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Animator character_Animator;
    GameObject character;
    GameObject[] char4;
    void Awake()
    {
        char4 = GameObject.FindGameObjectsWithTag("Char4");
    }
    public void StartAnimation() 
    {
        foreach (GameObject character in char4)
        {
            character_Animator = character.GetComponent<Animator>();
            character_Animator.SetBool("IsActive", true);
        }
    }
}
