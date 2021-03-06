using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

namespace AutumnYard
{
  public class InputHandler
  {
    public void ProcessInputs(ref InputState state)
    {
      //moveAxis = Input.GetAxis()
      //state.up = Keyboard.current.wKey.isPressed;
      //state.down = Keyboard.current.sKey.isPressed;
      if(Keyboard.current.wKey.isPressed) state.verticalAxis = 1;
      else if(Keyboard.current.sKey.isPressed) state.verticalAxis = -1;
      else state.verticalAxis = 0;
    }
  }
}
