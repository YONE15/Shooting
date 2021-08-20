using UnityEngine;
using System.Collections;

public class Bacground : MonoBehaviour
{

	void Update() {
		transform.Translate(0, -0.01f, 0);
		if (transform.position.y < -17.4f) {
			transform.position = new Vector3(0, 30f, 0);
		}
	}
}