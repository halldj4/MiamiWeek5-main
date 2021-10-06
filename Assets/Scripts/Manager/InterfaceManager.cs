using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField]
    private Button joinPlayerOne;

    [SerializeField]
    private Button joinPlayerTwo;

    //TODO: Add PlayerTwoButton reference

    [SerializeField]
    private SplitKeyboardPlayerInputManager playerInputManager;
    // Start is called before the first frame update
    void Start()
    {
        joinPlayerOne.onClick.AddListener(() => JoinPlayerOne());
        //TODO Listen for player two click event
        joinPlayerTwo.onClick.AddListener(() => JoinPlayerTwo());

    }

    private void JoinPlayerOne()
    {
        Debug.Log("BUTTON PRESSED, JOINPLAEYRONE INVOKED");
        if (!(joinPlayerOne.GetComponentInChildren<Text>().text == "Leave Player One"))
        {
            playerInputManager.JoinPlayer(0, "Keyboard&Mouse");
            joinPlayerOne.GetComponentInChildren<Text>().text = "Leave Player One";
        } else
        {
            playerInputManager.LeavePlayer(0);
        }
        //TODO flip text to say "Leave Player One"
 
        //TODO on click after player has joined, remove player

    }

    private void JoinPlayerTwo()
    {
        Debug.Log("BUTTON PRESSED, JOINPLAYERTWO INVOKED");
        if (!(joinPlayerTwo.GetComponentInChildren<Text>().text == "Leave Player Two"))
        {
            playerInputManager.JoinPlayer(1, "PlayerTwo");
            joinPlayerTwo.GetComponentInChildren<Text>().text = "Leave Player Two";
        }
        else
        {
            playerInputManager.LeavePlayer(1);
        }

    }

    //TODO Invoke JoinPlayer passing a playerIndex value and targeting a control scheme
    //TODO flip text after player has joined to say "Leave Player Two"
    //TODO on click after player has joined, remove player
}
