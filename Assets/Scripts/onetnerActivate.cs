using UnityEngine;

public class onetnerActivate : MonoBehaviour
{
    public GameObject dolly;
    void OnTriggerEnter(Collider other)
    {
        dolly.SetActive(true);
    }

}
