using UnityEngine;

public class UIObjectView : UIManagerView
{
    public void DestroyUIObject()
    {
        DeleteUIObjectView(this.gameObject);
    }

}
