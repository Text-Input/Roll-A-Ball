using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float Speed;
    private int Score = 0;
    private Rigidbody mov;

    public Text countText;
    public Text winText;

	// Use this for initialization
	void Start () {
        mov = GetComponent<Rigidbody>();
        countText.text = "Score: ";
	}

	void FixedUpdate() {
        Vector3 movement;
        movement.x = Input.GetAxis("Horizontal");
        movement.y = 0.0f;
        movement.z = Input.GetAxis("Vertical");

        mov.AddForce(movement * Speed);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
            Score++;
            UpdateUI(Score);
        }
    }

    void UpdateUI(int num) {

        countText.text = "Score: " + num.ToString();
        print(num);

        if (num == 20) {
            winText.gameObject.SetActive(true);
        }
    }

}
