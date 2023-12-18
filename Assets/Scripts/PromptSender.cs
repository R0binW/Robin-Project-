using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PromptSender : MonoBehaviour
{
    public TextMeshProUGUI prompt;

    public void SendPrompt()
    {
        Debug.Log(prompt.text); 
    }
}
