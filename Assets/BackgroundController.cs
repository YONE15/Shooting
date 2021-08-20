using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour
{

	void Update() {
		transform.Translate(0, -0.1f, 0);
		if (transform.position.y < -3.5f) {
			transform.position = new Vector3(0, 3.5f, 0);
		}
	}
}
