using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    static public bool  goalHit = false;

    void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Player") {
            Goal.goalHit = true;
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 1;
            mat.color = c;
        }
    }
}
