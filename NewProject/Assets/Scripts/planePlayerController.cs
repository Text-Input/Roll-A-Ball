using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planePlayerController : MonoBehaviour {

    public float Speed;
    private int Score = 0;
    private Transform transform;

    public Text countText;
    public Text winText;

    // Use this for initialization
    void Start() {
        
        countText.text = "Score: ";
        transform = GetComponent<Transform>();
    }

    void FixedUpdate() {
        Vector3 movement;
        Input.GetAxis("Horizontal");
        
        Input.GetAxis("Vertical");

        
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
