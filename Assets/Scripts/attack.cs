using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attack : MonoBehaviour {

private void OnTriggerEnter(Collider collision){
    if (collision.GetComponent<Enemy>()) {
        Destroy(collision.gameObject);
        }
    }
}