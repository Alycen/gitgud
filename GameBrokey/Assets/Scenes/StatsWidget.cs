using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsWidget : MonoBehaviour
{
    [SerializeField]
    private Text _strength;

    [SerializeField]
    private Text _constitution;

    [SerializeField]
    private Text _agility;

    [SerializeField]
    private Text _speed;

    private DataScriptableObject _data;


    public void BindNewData(DataScriptableObject data)
    {
        _data = data;

        Refresh();
    }

    public void Refresh()
    {
        _strength.text = _data.strength.ToString();
        _constitution.text = _data.consitution.ToString();
        _agility.text = _data.agility.ToString();
        _speed.text = _data.speed.ToString();
    }

}
