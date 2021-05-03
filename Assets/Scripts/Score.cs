using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {

    public Transform player;
    public Text score;
    float initialPlayerPosition;

    void Start() {
        initialPlayerPosition = player.position.z;
    }

    // Update is called once per frame
    void Update() {
        score.text = (player.position.z - initialPlayerPosition).ToString("0");
    }
}
