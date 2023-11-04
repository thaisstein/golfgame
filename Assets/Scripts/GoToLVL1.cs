using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToLVL1 : MonoBehaviour
{
    [SerializeField] private int indexlvl1;
    public Button ButtonStart;
    private void Start()
    {
        Button btn = ButtonStart.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    private void TaskOnClick()
    {
         SceneManager.LoadScene(indexlvl1);
       
    }
}
