using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Tooltip("Container the panels are parented to (inside the Canvas).")]
    public Transform spawnParent;

    private GameObject currentPanel;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void SpawnPanel(GameObject prefab)
    {
        if (prefab == null) return;

        if (currentPanel != null)
            Destroy(currentPanel);

        currentPanel = Instantiate(prefab, spawnParent);
        currentPanel.transform.localPosition = Vector3.zero;

        currentPanel.transform.localScale = Vector3.one;
        currentPanel.transform.localRotation = Quaternion.identity;
    }
}