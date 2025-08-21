using UnityEngine;

public class UIObjectView : UIManagerView
{
    private void Start()
    {
        Canvas.ForceUpdateCanvases();
    }

    public void DestroyUIObject()
    {
        DeleteUIObjectView(this.gameObject);
    }

}
