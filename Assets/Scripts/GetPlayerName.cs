using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerName : MonoBehaviour
{
    public InputField PlayerName; 
    public string myPlayerName;
    public Text ShowName; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetString("Name", myPlayerName);
    }

    public void DisplayName() {
        myPlayerName = PlayerName.text;
        ShowName.text = myPlayerName;
    }
}
