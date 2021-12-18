using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
    public AudioSource pickupCoin;

    void OnTriggerEnter(Collider other) {

        if (other.tag == "Player") {
            pickupCoin.Play();
        }
    }
}
