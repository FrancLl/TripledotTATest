using UnityEngine;

public class UIManagerView : MonoBehaviour
{
    bool navBarVisible = true;

    //I should create a UIObjectView custom editor to hide this serialized fields from the UIObject classes but I preferred to use my time on other stuff of the test.
    [SerializeField] Transform screenTransform;
    [SerializeField] Transform windowTransform;
    [SerializeField] Animator navBarAnimator;



    private void Awake()
    {
        navBarVisible = navBarAnimator.GetBool("Visible");

        Canvas.ForceUpdateCanvases();
    }

    public void InstanciateUIScreen(GameObject screen)
    {
        Instantiate(screen, screenTransform);
    }

    public void InstanciateUIWindow(GameObject screen)
    {
        Instantiate(screen, windowTransform);
    }

    public void DeleteUIObjectView(GameObject uiObject)
    {
        Destroy(uiObject);
    }

    public void NavBarChangeState()
    {
        if (navBarVisible == true)
        {
            navBarVisible = false;
        }
        else
        {
            navBarVisible = true;
        }

        navBarAnimator.SetBool("Visible", navBarVisible);
    }
}
