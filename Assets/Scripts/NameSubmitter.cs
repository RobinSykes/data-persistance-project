using UnityEngine;
using UnityEngine.UI;

public class NameSubmitter : MonoBehaviour
{
    public InputField nameInputField;

    public void SubmitName()
    {
            MainManager.inputTextName = nameInputField.text;
            Debug.Log("name submitted");
    }
}
