using UnityEngine;

public class UIManagerView : MonoBehaviour
{

    //I should create a UIObjectView custom editor to hide this serialized fields from the UIObject classes but I preferred to use my time on other stuff of the test.
    [SerializeField] Transform screenTransform;
    [SerializeField] Transform windowTransform;

    private void Awake()
    {
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
}
