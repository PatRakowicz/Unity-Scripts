using System.Collections;
using UnityEngine;

public class Rotate : MonoBehaviour {
	void Update () {
		transform.Rotate (new Vector3 (40, 60, 20) * Time.deltaTime);
	}
}
