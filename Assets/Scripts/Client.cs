using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public InputField IPInput = null;
    public InputField NameInput = null;
    public InputField MessageInput = null;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnConnectClick()
    {
        Debug.Log("IP: " + IPInput.text);
        Debug.Log("Name: " + NameInput.text);
    }

    public void OnSendClick()
    {
        Debug.Log("Message: " + MessageInput.text);
        MessageInput.text = "";
    }
}
