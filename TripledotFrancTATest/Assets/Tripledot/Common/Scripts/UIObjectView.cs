using UnityEngine;

public class UIObjectView : UIManagerView
{
    private void Start()
    {
        Debug.Log("Canvas Reload");
        Canvas.ForceUpdateCanvases();
    }

    public void DestroyUIObject()
    {
        DeleteUIObjectView(this.gameObject);
    }

}
