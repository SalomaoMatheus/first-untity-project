using UnityEngine;

public class CoinTrigger : MonoBehaviour {

    public GameObject Coin;
    public AudioSource audioData;

    void OnTriggerEnter () {
        audioData.Play(0);
        FindObjectOfType<Score>().scoreNumber = FindObjectOfType<Score>().scoreNumber + 1;
        Destroy(Coin);
    }

}
