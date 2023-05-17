using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Learn : MonoBehaviour
{
    public TextMeshProUGUI displayLetter;
    // Start is called before the first frame update
    void Start()
    {
        displayLetter.text = LetterState.Letter;
        Debug.Log(displayLetter);
    }

}
