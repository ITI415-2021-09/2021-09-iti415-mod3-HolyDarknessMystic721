using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControllerWin : MonoBehaviour {
    public TextMeshProUGUI scoreCounter;

    private int score;

    private Rigidbody rb;

    public GameObject winText;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        winText.SetActive(false);

        score = 0;

        SetCountText();
    }

    void SetCountText() {

        scoreCounter.text = "Score: " + score.ToString();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Collectable")) {

            other.gameObject.SetActive(false);

            score = score + 100;
            
            SetCountText();
        }

        if (other.gameObject.tag == "Goal") {
            
            winText.SetActive(true);
        }
    }
}
