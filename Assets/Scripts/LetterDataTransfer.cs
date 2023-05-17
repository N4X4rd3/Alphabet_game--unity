using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class LetterDataTransfer : MonoBehaviour
{
    public string Letter;
    [SerializeField] TextMeshProUGUI LetterButton;
    [SerializeField] TextMeshProUGUI Learn;
    [SerializeField] TextMeshProUGUI Draw;
    [SerializeField] TextMeshProUGUI Find;
    [SerializeField] GameObject LetterScreen;
    void Start()
    {
        LetterButton.text = Letter;
    }
    public void TaskOnClick()
    {
        Debug.Log("Ты нажал на кнопку");
        LetterScreen.SetActive(true);
        Learn.text = Letter + "_Learn";
        Draw.text = Letter + "_Draw";
        Find.text = Letter + "_Find";
        LetterState.Letter = Letter;
    }
}
