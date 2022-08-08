using UnityEngine;

[RequireComponent(typeof(PlayerState))]
public class PlayerJump : MonoBehaviour {
  [SerializeField, Min(0f)] private float acceleration = 12000f;
  
  private Rigidbody rb;
  private PlayerState state;
  
  private void Start() {
    rb = GetComponent<Rigidbody>();
    state = GetComponent<PlayerState>();
  }

  private void Update() {
    if (Input.GetButtonDown("Jump") && state.IsGrounded) {
      rb.AddForce(acceleration * Vector3.up, ForceMode.Force);
    }
  }
}
