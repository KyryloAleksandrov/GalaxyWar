using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : BaseUnit
{
    [SerializeField] private MoveAction moveAction;
    
    // Start is called before the first frame update
    void Start()
    {
        unitType = UnitType.Ship;
        Deselect();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Select()
    {
        base.Select();

    }

}
