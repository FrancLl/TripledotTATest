using UnityEngine;

public class UIManagerView : MonoBehaviour
{

    GameObject actualScreen;

    //I should create a UIObjectView custom editor to hide this two fields from the UIObject classes but I prefered to use my time on other stuff of the test.
    [SerializeField] Transform screenTransform;
    [SerializeField] Transform windowTransform;

    public void InstanciateUIScreen(GameObject screen)
    {
        actualScreen = Instantiate(screen, screenTransform);
    }

    public void InstanciateUIWindow(GameObject screen)
    {
        actualScreen = Instantiate(screen, windowTransform);
    }

    public void DeleteUIObjectView(GameObject uiObject)
    {
        Destroy(uiObject);
    }
}
