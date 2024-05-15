using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChangeScene : MonoBehaviour
{
    public Button button;
    private bool isChoose = false;

    void changeColor()
    {
        //SceneManager.LoadScene(2);
        ColorBlock colorBlock = button.colors;
        isChoose = !isChoose;
        colorBlock.normalColor = isChoose ? new Color(0, 1f, 0, 1f) : Color.white;
        colorBlock.selectedColor = isChoose ? new Color(0, 1f, 0, 1f) : Color.white;
        button.colors = colorBlock;
        Debug.Log("Pressed");
    }
}
