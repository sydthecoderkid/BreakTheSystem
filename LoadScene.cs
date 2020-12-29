using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private static Button thisButton;
    public string sceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        thisButton = this.GetComponent<Button>();
        thisButton = assignlistener(thisButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Button assignlistener(Button button)
    {
        button.onClick.AddListener(loadScene);

        return button;
    }

    void loadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
