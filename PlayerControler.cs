using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    public float speed;
    public Text CountText;
    public Text WinText;
	
	private Rigidbody rb;
	private int count;
	
	
    void Start () {
        rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		WinText.text = "";
    }

    void FixedUpdate () {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText();
		}
	}
	void SetCountText() {
        CountText.text = "Count: " + count.ToString ();
        if (count >= 9) {
            WinText.text = "Congrats! You Win!";
		}
	}
}
