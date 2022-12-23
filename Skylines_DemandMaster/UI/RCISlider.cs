﻿using UnityEngine;
using ColossalFramework.UI;

namespace DemandMasterPhenix
{
    public class RCISlider : UISlider
    {
        private UISprite _ThumbObj;

        public override void Start()
        {
            base.Start();

            _ThumbObj = AddUIComponent<UISprite>();
            _ThumbObj.spriteName = "SliderBudget";

            size = new Vector2(200, 10);

            backgroundSprite = "LevelBarBackground";
            canFocus = true;

            maxValue = 100f;
            minValue = 0f;
            orientation = UIOrientation.Horizontal;
            scrollWheelAmount = 1f;
            stepSize = 1f;
            thumbObject = _ThumbObj;
            thumbOffset = new Vector2(0, 2);
        }

    }
}
