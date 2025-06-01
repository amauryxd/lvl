using UnityEngine;

public class triggerdesactivate : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
}
