using UnityEngine;

public class CommissionButton : MonoBehaviour
{
    [Tooltip("The Commission Board this button spawns.")]
    public GameObject prefabToSpawn;

    [Tooltip("The panel this button belongs to — it will be hidden/removed when clicked.")]
    public GameObject panelToClose;

    public void OnClick()
    {
        if (panelToClose != null)
            panelToClose.SetActive(false);
           
        UIManager.Instance.SpawnPanel(prefabToSpawn);
    }
}