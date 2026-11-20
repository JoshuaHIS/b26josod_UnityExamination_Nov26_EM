using UnityEngine;
using UnityEngine.InputSystem;
public class WalkCheck : MonoBehaviour
{
    public InputActionAsset JPlayerAction;
    public Animator JOAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        JOAnimator = GetComponent<Animator>();
        
        JOAnimator.SetBool("isWalking", false);
        JOAnimator.SetBool("isJumping", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (JPlayerAction.FindAction("Move").IsPressed())
        {
            JOAnimator.SetBool("isWalking", true);
        }
        else
        {
            JOAnimator.SetBool("isWalking", false);
        }
        
        if (JPlayerAction.FindAction("Jump").IsPressed())
        {
            JOAnimator.SetBool("isJumping", true);
        }
        else
        {
            JOAnimator.SetBool("isJumping", false);
        }
    }
}
