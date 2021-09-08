using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public InputField playerNameInput;

    // Start is called before the first frame update
    void Start()
    {
        SaveAndLoad.Instance.LoadScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoneButton()
	{
        SaveAndLoad.Instance.playerName = playerNameInput.text;
        SaveAndLoad.Instance.SaveScore();
        SceneManager.LoadScene(0);
    }
}
