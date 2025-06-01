using UnityEngine;

public class PuenteScrip : MonoBehaviour
{
    public Vector3[] posicionOriginal;
    public GameObject[] punetes;
    Vector3 velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        punetes[0].transform.localPosition = Vector3.SmoothDamp(punetes[0].transform.localPosition, posicionOriginal[0], ref velocity, 0.5f);
        punetes[1].transform.localPosition = Vector3.SmoothDamp(punetes[0].transform.localPosition, posicionOriginal[1], ref velocity, 0.5f);
        punetes[2].transform.localPosition = Vector3.SmoothDamp(punetes[0].transform.localPosition, posicionOriginal[2], ref velocity, 0.5f);
        punetes[3].transform.localPosition = Vector3.SmoothDamp(punetes[0].transform.localPosition, posicionOriginal[3], ref velocity, 0.5f);
        punetes[4].transform.localPosition = Vector3.SmoothDamp(punetes[0].transform.localPosition, posicionOriginal[4], ref velocity, 0.5f);
        punetes[5].transform.localPosition = Vector3.SmoothDamp(punetes[0].transform.localPosition, posicionOriginal[5], ref velocity, 0.5f);
        punetes[6].transform.localPosition = Vector3.SmoothDamp(punetes[0].transform.localPosition, posicionOriginal[6],ref velocity,0.5f);
    }
}
