using UnityEngine;

public class EnableOnRun : MonoBehaviour
{
    public GameObject[] objectsToEnable;

    private void Start()
    {
        foreach (GameObject obj in objectsToEnable)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }
    }
}