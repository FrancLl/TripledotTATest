using UnityEngine;

public class CloseButtonView : MonoBehaviour
{
    [SerializeField] Animator animator;

    public void Close()
    {
        animator.SetTrigger("Close");
    }
}
