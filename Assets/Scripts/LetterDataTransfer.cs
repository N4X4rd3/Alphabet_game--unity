using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class LetterDataTransfer : MonoBehaviour
{

    [SerializeField] public string Letter;
    [SerializeField] TextMeshProUGUI m_Object;
    // Start is called before the first frame update
    void Start()
    {
        m_Object.text = Letter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
