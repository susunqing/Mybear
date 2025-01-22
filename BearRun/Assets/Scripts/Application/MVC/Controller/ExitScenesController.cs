﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ExitScenesController : Controller
{
    public override void Execute(object data)
    {
        ScenesArgs e = data as ScenesArgs;
        switch (e.scnesIndex)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                Game.Instance.objectPool.Clear();
                break;
        }
        GameModel gm = GetModel<GameModel>();
        gm.lastIndex = e.scnesIndex;
    }
}