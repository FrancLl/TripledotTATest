using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine.EventSystems;
using JetBrains.Annotations;

public class BottomBarView : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] Animator ContentToggle;
    [SerializeField] List<NavBarButtonView> navBarButtons = new List<NavBarButtonView>();
    [SerializeField] Animator buttonSelector;
    [SerializeField] RectTransform buttonSelectorRT;
    float buttonSelectorDestination = 0.0f;
    bool aButtonIsSelected = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Not selected");
        foreach (NavBarButtonView navBarButton in navBarButtons)
        {
            navBarButton.selected = false;
        }
        NavBarButtonsState();
    }

    public void ButtonPressed(NavBarButtonView navbarButtonSelected)
    {
        foreach (NavBarButtonView navBarButton in navBarButtons)
        {
            if (navBarButton != navbarButtonSelected)
            {
                navBarButton.selected = false;
            }
            else
            {
                navBarButton.selected = true;
            }
        }
        NavBarButtonsState();
    }


    void NavBarButtonsState()
    {
        for (int i = 0; i < navBarButtons.Count; i++)
        {
            Debug.Log(i);
            Debug.Log("COUNT = " + navBarButtons.Count);

            if (navBarButtons[i].selected)
            {
                //DisselectOthers(navBarButtons[i]);
                MoveButtonSelector(navBarButtons[i]);
                buttonSelector.SetBool("Enabled", true);
                ContentToggle.SetTrigger("Activated");
                Debug.Log(navBarButtons[i]);
                break;
            }
            else if (i == navBarButtons.Count - 1 && !navBarButtons[i].selected)
            {
                Debug.Log("Closed");
                ContentToggle.SetTrigger("Closed");
                buttonSelector.SetBool("Enabled", false);
            }
        }
    }

    /*void DisselectOthers(NavBarButtonView selectedButton)
    {
        foreach(NavBarButtonView navBarButton in navBarButtons)
        {
            if (navBarButton != selectedButton)
            {
                Debug.Log("Disselected");
                navBarButton.selected = false;
            }
        }
    }*/
    void MoveButtonSelector(NavBarButtonView buttonDestination)
    {
        Debug.Log("Move");
    }
}
