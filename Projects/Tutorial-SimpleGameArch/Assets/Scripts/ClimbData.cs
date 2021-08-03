using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AutumnYard
{
  public class ClimbData : MonoBehaviour
  {
    [SerializeField] private Transform nodeTop;
    [SerializeField] private Transform nodeBottom;
    private float distance;

    public Vector3 Top => nodeTop.position;
    public Vector3 Bottom => nodeBottom.position;

    private void Awake()
    {
      distance = Vector3.Distance(Top, Bottom);
    }

    public void Move(ref ClimbState state, in InputState input, in float timeDelta)
    {
      // TODO: Mover el state segun el input, lerpeado por el timeDelta
      
    }
  }
}