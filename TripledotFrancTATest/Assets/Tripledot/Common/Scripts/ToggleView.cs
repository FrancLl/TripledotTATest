using UnityEngine;
using UnityEngine.UI;

public class ToggleView : MonoBehaviour
{
    [SerializeField] Toggle toggleComponent;
    [SerializeField] Animator toggleAnimator;

    private void Awake()
    {
        ToggleState();
    }

    public void ToggleState()
    {
        if (toggleComponent.isOn)
        {
            toggleAnimator.SetBool("Toggle", true);
        }
        else
        {
            toggleAnimator.SetBool("Toggle", false);
        }
    }
}
