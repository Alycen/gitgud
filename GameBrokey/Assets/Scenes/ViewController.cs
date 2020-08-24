using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewController : MonoBehaviour
{
    [SerializeField]
    private DataScriptableObject _viewData;


    [SerializeField]
    private StatsWidget _statsWidget;

    [SerializeField]
    private Text _name;

    [SerializeField]
    private Button RandomizeButton;

    public void Start()
    {
        RefreshData();
    }

    public void RefreshData() // Check this method - are there issues? 
    {
        _name.text = _viewData.name;

        _statsWidget.BindNewData(_viewData);

        RandomizeButton.onClick.AddListener(OnRandomizeClicked);
    }

    private void OnRandomizeClicked()
    {
        // TODO : Randomize the data from MySO and update the screen
        RefreshData();
    }
}
