using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyOperators : MonoBehaviour
{
    private TextMeshProUGUI TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayMessage()
    {
        TextMeshPro.text = "Botton Clicked!";
    }
}
