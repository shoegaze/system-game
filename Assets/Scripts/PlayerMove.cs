using UnityEngine;

public class PlayerMove : MonoBehaviour {
  [SerializeField] private new Camera camera;
  [SerializeField, Min(0f)] private float speed;
  
  private Rigidbody rb;
  
  private void Awake() {
    rb = GetComponent<Rigidbody>();
  }

  private void Update() {
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");
    var ct = camera.transform;
    
    var dir = (h * ct.right + v * ct.forward).normalized;
    rb.velocity = speed * dir;
  }
}
