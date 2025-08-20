using UnityEngine;

public class ButtonSettingsView : MonoBehaviour
{
    [SerializeField] GameObject windowSettings;
    [SerializeField] Transform parent;
    public void OpenSettings()
    {
        Debug.Log("Instantciate");
        Instantiate(windowSettings, parent);
    }
}
