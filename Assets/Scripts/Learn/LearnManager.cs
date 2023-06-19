using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnManager : MonoBehaviour
{
    [SerializeField] private LearnUI learnUI;
    [SerializeField] private LearnDataScriptable learnData;

    private List<Question> questions;
    private Question selectedQuestion;

    // Start is called before the first frame update
    void Start()
    {
        questions = learnData.questions;

        SelectQuestion();
    }

    // Update is called once per frame
    void SelectQuestion()
    {
        int val = Random.Range(0, questions.Count);
        selectedQuestion = questions[val];

        learnUI.SetQuestion(selectedQuestion);
    }

    public bool Answer(string answered)
    {
        bool correctAns = false;
        
        if(answered == selectedQuestion.correctAns)
        {
            //Yes
            correctAns= true;
        }    
        else
        {
            //No
        }

        Invoke("SelectQuestion", 0.4f);

        return correctAns;
    }
}

[System.Serializable]
public class Question
{
    public string questionInfo;
    public QuestionType questionType;
    public Sprite questionImg;
    public AudioClip questionClip;
    public List<string> options;
    public string correctAns;
}
[System.Serializable]
public enum QuestionType
{
    TEXT,
    IMAGE,
    AUDIO
}