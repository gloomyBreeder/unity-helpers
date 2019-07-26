using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshPathDebugger : MonoBehaviour
{
  /// <summary> It's a super easy script can help you to debug path of your NavMesh agent
  /// For example, you have a player and AI who follows your player. If you attach
  /// LineRenderer component and this script to player you'll see calculated AI path from AI to player </summary>
  [SerializeField]
  private NavMeshAgent _agent;
  private LineRenderer _linerenderer;

  void Start()
  {
    _linerenderer = GetComponent<LineRenderer>();
  }

  void Update()
  {
    if (_agent.hasPath)
    {
      _linerenderer.positionCount = _agent.path.corners.Length;
      _linerenderer.SetPositions(_agent.path.corners);
      _linerenderer.enabled = true;
    }
    else
    {
      _linerenderer.enabled = false;
    }

  }
}
