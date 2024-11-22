using TMPro;
using UnityEngine;

public class IntroFrontLogic : MonoBehaviour
{
    [SerializeField] private TMP_InputField m_RoomNameInputField;

    public void Host()
    {
        Debug.Log("Host: " +  m_RoomNameInputField.text);
    }

    public void Join()
    {
        Debug.Log("Join: " +  m_RoomNameInputField.text);
    }
}
