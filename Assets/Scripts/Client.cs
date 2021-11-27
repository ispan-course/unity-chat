using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ChatCore;

public class Client : MonoBehaviour
{
    public InputField IPInput = null;
    public InputField NameInput = null;
    public InputField MessageInput = null;

    public Button ConnectButton = null;
    public Button SendButton = null;

    private bool m_isConnected = false;
    private ChatClient m_client = null;
    
    // Start is called before the first frame update
    void Start()
    {
        MessageInput.interactable = false;
        SendButton.interactable = false;
        m_client = new ChatClient();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnConnectClick()
    {
        Debug.Log("IP: " + IPInput.text);
        Debug.Log("Name: " + NameInput.text);

        if (string.IsNullOrWhiteSpace(IPInput.text))
        {
            Debug.Log("IP can't empty!");
            return;
        }

        if (string.IsNullOrWhiteSpace(NameInput.text))
        {
            Debug.Log("Name can't empty!");
            return;
        }

        m_isConnected = m_client.Connect(IPInput.text, 4099);

        if (m_isConnected)
        {
            ConnectButton.interactable = false;
            m_client.SetName(NameInput.text);

            MessageInput.interactable = true;
            SendButton.interactable = true;
        }
    }

    public void OnSendClick()
    {
        if (string.IsNullOrWhiteSpace(MessageInput.text))
        {
            Debug.Log("Message can't empty!");
            return;
        }

        Debug.Log("Message: " + MessageInput.text);
        m_client.SendMessage(MessageInput.text);
        MessageInput.text = "";
    }
}
