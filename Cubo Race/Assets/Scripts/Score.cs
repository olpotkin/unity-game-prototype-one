using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player_pos;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player_pos.position.z);
        scoreText.text = player_pos.position.z.ToString("0");
    }
}
