using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using _Code.UI;

public class WebTouchInput : MonoBehaviour
{
    public enum MoveState { Left, Right, Idle};

    PlayerController[] controllers;

    Dictionary<PlayerController.ButtonInputType, bool> buttonPressed;
    
    void Start()
    {
        controllers = FindObjectsOfType<PlayerController>();
        print($"{controllers.Length} controllers");

        buttonPressed = new Dictionary<PlayerController.ButtonInputType, bool>();
        buttonPressed.Add(PlayerController.ButtonInputType.Left, false);
        buttonPressed.Add(PlayerController.ButtonInputType.Right, false);
        buttonPressed.Add(PlayerController.ButtonInputType.Jump, false);
    }

    public void ButtonDown(PlayerController.ButtonInputType type)
    {
        switch (type)
        {
            case PlayerController.ButtonInputType.Left:
                Left();
                break;
            case PlayerController.ButtonInputType.Right:
                Right();
                break;
            case PlayerController.ButtonInputType.Jump:
                if (buttonPressed[type] == false)
                    Jump();
                break;
        }
        buttonPressed[type] = true;

    }

    public void ButtonUp(PlayerController.ButtonInputType type)
    {
        buttonPressed[type] = false;
        if (!buttonPressed[PlayerController.ButtonInputType.Left] &&
            !buttonPressed[PlayerController.ButtonInputType.Right])
            Zero();

        
    }


    void Left() => SetForAll(PlayerController.ButtonInputType.Left);
    void Right() => SetForAll(PlayerController.ButtonInputType.Right);
    void Jump() => SetForAll(PlayerController.ButtonInputType.Jump);
    void Zero() => SetForAll(PlayerController.ButtonInputType.Zero);

    void SetForAll(PlayerController.ButtonInputType type)
    {
        foreach (PlayerController controller in controllers)
            SetInput(controller, type);
    }

    void SetInput(PlayerController controller, PlayerController.ButtonInputType type)
        => controller.ButtonInput(type);
}
