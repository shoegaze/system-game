using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
  [SerializeField, Min(0f)] private float speed;
  
  private Rigidbody rb;
  
  private void Awake() {
    rb = GetComponent<Rigidbody>();
  }

  private void Update() {
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");

    var dir = (h * Vector3.right + v * Vector3.forward).normalized;
    rb.velocity = speed * dir;
  }
}
