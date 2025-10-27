using UnityEngine;

public class Controller : MonoBehaviour
{
    Animator animator;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
           
            animator.SetFloat("Blend", 0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
          
            animator.SetFloat("Blend", 1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
           
            animator.SetFloat("Blend", 2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            
            animator.SetFloat("Blend", 3);
        }
    }
}
