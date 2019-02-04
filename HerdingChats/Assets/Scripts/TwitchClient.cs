using System.Collections;
using System.Collections.Generic;
using TwitchLib.Unity;
using TwitchLib.Client.Models;
using UnityEngine;

public class TwitchClient : MonoBehaviour
{

    public Client client;
    public string channelName = "sulu244";
    public GameObject CatControllerObject;

    private CatController catController;
    // Start is called before the first frame update
    void Start()
    {
        Application.runInBackground = true;

        ConnectionCredentials credentials = new ConnectionCredentials("mrtwitchboto", Secrets.Instance.accessToken);
        client = new Client();
        client.Initialize(credentials, channelName);

        client.OnMessageReceived += ChatListen;
        client.OnChatCommandReceived += CommandListen;

        client.Connect();

        catController = CatControllerObject.GetComponent<CatController>();
    }

    private void CommandListen(object sender, TwitchLib.Client.Events.OnChatCommandReceivedArgs e)
    {
        if (e.Command.CommandText == "help")
        {
            Help();
        }
        else if (e.Command.CommandText == "Up" || e.Command.CommandText == "up" || e.Command.CommandText == "Down" || e.Command.CommandText == "down"
            || e.Command.CommandText == "Left" || e.Command.CommandText == "left" || e.Command.CommandText == "Right" || e.Command.CommandText == "right")
        {
            catController.ChatMoveCommand(e.Command.CommandText);
        }
        else
        {
            client.SendMessage(client.JoinedChannels[0],"Command not recognized, please use !Help to get the list of commands.");
        }
    }

    private void ChatListen(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
    {
        Debug.Log("Someone just sent a message in Twitch Chat");
        Debug.Log(e.ChatMessage.Username + ": " + e.ChatMessage.Message);
    }

    private void Help()
    {
        client.SendMessage(client.JoinedChannels[0], "Welcome to Herding Chats! You can use chat commands to help the cats avoid the player! The valid commands are: !Up, !Down, !Left, !Right");
    }
}
