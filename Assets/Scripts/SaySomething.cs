using UnityEngine;

public class SaySomething : MonoBehaviour {
  public void SayHello(RaycastHit hitInfo) {
    Debug.LogFormat("Hello, {0}!", name);
  }

  public void SayGoodbye() {
    Debug.Log("Goodbye!");
  }
}
