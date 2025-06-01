using TMPro;
using UnityEngine;

public class lodelpuente : MonoBehaviour
{
    public GameObject puenteGO;
    public TextMeshProUGUI texto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            puenteGO.SetActive(true);
            texto.text = "Puzzle completado";
            texto.color = Color.red;
        }
    }
}
