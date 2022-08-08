using Sirenix.OdinInspector;
using UnityEngine;

public class PlayerState : MonoBehaviour {
  [SerializeField, ReadOnly] private bool isGrounded;

  public bool IsGrounded => isGrounded;

  public void SetGrounded() {
    isGrounded = true;
  }

  public void SetFloating() {
    isGrounded = false;
  }
}
