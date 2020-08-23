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

    public void Start()
    {
        SetViewData();
    }

    public void SetViewData()
    {
        _name.text = _viewData.Name;
        _statsWidget.BindNewData(_viewData);
    }
}
