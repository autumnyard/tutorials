using UnityEngine;

namespace AutumnYard
{
  public class PlayerClimb : MonoBehaviour
  {
    private ClimbData currentData;
    private ClimbState climbState = new ClimbState();
    private Rigidbody rb;
    private InputState inputState;
    private InputHandler inputHandler;


    private void Awake()
    {
      rb = GetComponent<Rigidbody>();
      inputHandler = new InputHandler();
    }


    private void OnEnable()
    {
      SetOnClimb(currentData);
    }

    private void SetOnClimb(ClimbData data)
    {
      currentData = data;
      rb.position = data.Bottom;
    }


    private void Update()
    {
      inputHandler.ProcessInputs(ref inputState);
      currentData.Move(ref climbState, in inputState, Time.deltaTime);
    }

  }
}