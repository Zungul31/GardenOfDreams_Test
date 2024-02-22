using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreenVM : ViewModelBase<GameOverScreenView>
{
    public GameOverScreenVM(Canvas canvas, GameCore gameCore) : base(canvas, gameCore) { }

    public override void Engage()
    {
        base.Engage();
        
        
    }

    public override void Disengage()
    {
        
        
        base.Disengage();
    }
}
