using System.Collections;
using UnityEngine;

public class zonaDesapair : MonoBehaviour
{
    public GameObject[] objetosxd;
    public GameObject camara1;
    public GameObject camara2;
    Vector3 newPos;
    Vector3 velocity;
    bool oncepas = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newPos = transform.position - new Vector3(0, 15, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!objetosxd[0].activeInHierarchy && !objetosxd[1].activeInHierarchy && !objetosxd[2].activeInHierarchy && !objetosxd[3].activeInHierarchy)
        {
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, newPos, ref velocity, 5f);
            camaras();
        }
    }
    public void camaras()
    {
        if (oncepas)
        {
            oncepas = false;
            StartCoroutine(camaracosa());
        }
    }
    public IEnumerator camaracosa()
    {
        camara1.SetActive(true);
        yield return new WaitForSeconds(4);
        camara1.SetActive(false);
        camara2.SetActive(true);
        yield return new WaitForSeconds(3);
        camara2.SetActive(false);
    }
}
