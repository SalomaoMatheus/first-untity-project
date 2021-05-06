using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {

    public int scoreNumber = 0;
    public Text score;
    // public Transform player;
    // float initialPlayerPosition;

    // void Start() {
    //     initialPlayerPosition = player.position.z;
    // }

    // // Update is called once per frame
    void Update() {
        score.text = scoreNumber.ToString("0");
    }
}
