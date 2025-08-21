using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine.EventSystems;
using JetBrains.Annotations;

public class BottomBarView : MonoBehaviour
{
    [SerializeField] Animator ContentToggle;
    [SerializeField] List<NavBarButtonView> navBarButtons = new List<NavBarButtonView>();
    [SerializeField] Animator buttonSelector;
    [SerializeField] RectTransform buttonSelectorRT;
    [SerializeField] float selectorTravelTime;

    public void OutsideClick()
    {
        DisselectAllButtons();
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

            if (navBarButtons[i].selected)
            {
                MoveButtonSelector(navBarButtons[i]);
                buttonSelector.SetBool("Enabled", true);
                ContentToggle.SetTrigger("Activated");
                break;
            }
            else if (i == navBarButtons.Count - 1 && !navBarButtons[i].selected)
            {
                ContentToggle.SetTrigger("Closed");
                buttonSelector.SetBool("Enabled", false);
            }
        }
    }

    void MoveButtonSelector(NavBarButtonView buttonDestination)
    {
        buttonSelectorRT.DOAnchorPos(new Vector2(buttonDestination.selectedPosition, 0), selectorTravelTime);
    }

    public void DisselectAllButtons()
    {
        foreach (NavBarButtonView navBarButton in navBarButtons)
        {
            navBarButton.selected = false;
        }
        NavBarButtonsState();
    }
}
