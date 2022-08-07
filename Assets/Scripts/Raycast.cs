using UnityEngine;
using UnityEngine.Events;

public class Raycast : MonoBehaviour {
  [SerializeField, Min(0f)] private float distance = 1f;
  [SerializeField] private LayerMask layerMask = 0;
  [SerializeField] private UnityEvent<RaycastHit> onHit;
  [SerializeField] private UnityEvent onMiss;

  private void Update() {
    var t = transform;
    bool hit = Physics.Raycast(
            t.position, 
            t.forward, 
            out var hitInfo,
            distance, 
            layerMask
    );

    if (hit) {
      onHit.Invoke(hitInfo);
    }
    else {
      onMiss.Invoke();
    }
  }

  private void OnDrawGizmos() {
    Gizmos.color = Color.red;
    
    var t = transform;
    var o = t.position;
    Gizmos.DrawLine(
            o,
            o + distance * t.forward
    );
  }
}
