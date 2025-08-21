using TMPro;
using UnityEngine;

public class ScreenHomeView : MonoBehaviour
{
    string hide = new string("Hide NavBar");
    string show = new string("Show NavBar");

    [SerializeField] Animator navBarAnimator;
    [SerializeField] TextMeshProUGUI navBarButtonText;


    private void Start()
    {
        navBarButtonTextChange();
    }
    public void navBarButtonTextChange()
    {
        if (navBarAnimator.GetBool("Visible"))
        {
            navBarButtonText.text = hide;
        }
        else
        {
            navBarButtonText.text = show;
        }
    }
}
