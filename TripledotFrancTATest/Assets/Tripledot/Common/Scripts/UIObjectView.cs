using UnityEngine;

public class UIObjectView : UIManagerView
{
    protected override void Awake()
    {
        
    }

    private void Start()
    {
        Canvas.ForceUpdateCanvases();
    }
    public void DestroyUIObject()
    {
        DeleteUIObjectView(this.gameObject);
    }

}
