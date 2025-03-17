using UnityEngine;
using Unity.Netcode;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DachaClient : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;
    public Text messageText;

    private NetworkManager networkManager;

    private void Start()
    {
        networkManager = NetworkManager.Singleton;

        // Подключаемся к серверу
        networkManager.StartClient();
    }

    // Метод для регистрации
    public void Register()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        if (networkManager.IsClient)
        {
            var dachaServer = FindObjectOfType<DachaServer>();
            if (dachaServer != null)
            {
                dachaServer.RegisterServerRpc(username, password);
                messageText.text = "Запрос на регистрацию отправлен.";
            }
        }
    }

    // Метод для авторизации
    public void Login()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        if (networkManager.IsClient)
        {
            var dachaServer = FindObjectOfType<DachaServer>();
            if (dachaServer != null)
            {
                dachaServer.LoginServerRpc(username, password);
                messageText.text = "Запрос на авторизацию отправлен.";
            }
        }
    }
}
