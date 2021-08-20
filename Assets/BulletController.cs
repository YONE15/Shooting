using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{

	public GameObject explosionPrefab;

	void Update() {
		transform.Translate(0, 0.2f, 0);

		if (transform.position.y > 5) {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		// 衝突したときにスコアを更新する
		GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

		Destroy(coll.gameObject);
		Destroy(gameObject);
	}
}

