using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnManager : MonoBehaviour
{
    [SerializeField]
    private List<Question> questions;

    private Question selectedQuestion;

    // Start is called before the first frame update
    void Start()
    {
        SelectQuestion
    }

    // Update is called once per frame
    void SelectQuestion()
    {
        int val = Random.Range(0,questions.Count)
        selectedQuestion = questions[val]
    }

    void Answer()
    {
        
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