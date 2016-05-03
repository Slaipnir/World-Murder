using UnityEngine;
using System.Collections;

public class DialogueNPC : MonoBehaviour {
    public string[] AnswerButton;
    public string[] Questions;
    bool DisplayDialogue = false;
    bool ActivateQuest = false;

    // Use this for initialization
    void Start()
    {
        
    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(500, 450, 400, 400));
        if (DisplayDialogue && !ActivateQuest)
        {
            GUILayout.Label(Questions[0]);
            GUILayout.Label(Questions[1]);
            if (GUILayout.Button(AnswerButton[0]))
            {
                ActivateQuest = true;
                DisplayDialogue = false;
            }
            if (GUILayout.Button(AnswerButton[1]))
            {
                DisplayDialogue = false;
            }
        }
        if (DisplayDialogue && ActivateQuest)
        {
            GUILayout.Label(Questions[2]);
            if (GUILayout.Button(AnswerButton[2]))
            {
                DisplayDialogue = false;
            }
        }
        GUILayout.EndArea();
    }

    void OnTriggerEnter(Collider other)
    {
        DisplayDialogue = true;
    }

    void OnTriggerExit(Collider other)
    {
        DisplayDialogue = false;
    }
}
