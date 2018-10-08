using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generate : MonoBehaviour
{
    [SerializeField]
    InputField widthText;
    [SerializeField]
    InputField heightText;
    [SerializeField]
    InputField minesText;
    int width;
    int height;
    int mines;
    Spawn spawn;

    void Start()
    {
        spawn = gameObject.AddComponent<Spawn>();
    }

    public void name()
    {
        if (int.TryParse(widthText.text, out width) && int.TryParse(heightText.text, out height))
        {
            spawn.GenerateMap(width, height);
        }
        else
        {
            Debug.Log("Not a number");
        }
    }
	
	// Update is called once per frame
	void Update()
    {
		
	}
}
