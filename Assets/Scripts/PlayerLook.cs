using UnityEngine;

public class PlayerLook : MonoBehaviour {
  [SerializeField] private new Camera camera;
  [SerializeField, Min(0f)] private float horizontalSensitivity = 1f;
  [SerializeField, Min(0f)] private float verticalSensitivity = 1f;
 

  private void Update() {
    float mx = Input.GetAxis("Mouse X");
    float my = Input.GetAxis("Mouse Y");
    var ct = camera.transform;
    
    ct.Rotate(0f, horizontalSensitivity * mx, 0f, Space.World);
    ct.Rotate(-verticalSensitivity * my, 0f, 0f, Space.Self);
  }
}
