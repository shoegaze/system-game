using UnityEngine;

public class PlayerMove : MonoBehaviour {
  [SerializeField] private new Camera camera;
  [SerializeField, Min(0f)] private float maxSpeed = 10;
  [SerializeField, Min(0f)] private float acceleration = 14;
  [SerializeField, Min(0f)] private float deceleration = 36;
  
  private Rigidbody rb;
  private Vector3 dir;
  
  private void Awake() {
    rb = GetComponent<Rigidbody>();
  }

  private void Update() {
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");
    var ct = camera.transform;
    
    dir = (h * ct.right + v * ct.forward).normalized;
  }

  private void FixedUpdate() {
    var vel = rb.velocity;

    if (Mathf.Approximately(dir.sqrMagnitude, 0f)) {
      float d = Mathf.Min(deceleration, vel.magnitude /  Time.fixedDeltaTime);
      
      var velXY = new Vector3(vel.x, 0f, vel.z);
      var back = -velXY.normalized;
      
      rb.AddForce(d * back, ForceMode.Acceleration);
    }
    else {
      rb.AddForce(acceleration * dir, ForceMode.Acceleration);
    }

    rb.velocity = Vector3.ClampMagnitude(vel, maxSpeed);
  }
}
