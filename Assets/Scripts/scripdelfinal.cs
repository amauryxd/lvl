using System.Collections;
using StarterAssets;
using UnityEngine;

public class scripdelfinal : MonoBehaviour
{
    public GameObject dolly;
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public GameObject CanvaFinal;
    public GameObject player;
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(cineFinal());
    }
    public IEnumerator cineFinal()
    {
        player.GetComponent<ThirdPersonController>().enabled = false;
        player.GetComponent<Animator>().SetFloat("Speed", 0);
        player.transform.position = new Vector3(0,6.220495f,281.27f);
        dolly.SetActive(false);
        Cam1.SetActive(true);
        yield return new WaitForSeconds(3);
        Cam1.SetActive(false);
        Cam2.SetActive(true);
        yield return new WaitForSeconds(3);
        Cam2.SetActive(false);
        player.transform.position = new Vector3(0,6.220495f,298.99f);
        Cam3.SetActive(true);
        yield return new WaitForSeconds(3);
        player.transform.position = new Vector3(0,6.220495f,281.27f);
        Cam3.SetActive(false);
        Cam4.SetActive(true);
        CanvaFinal.SetActive(true);
    }
}
