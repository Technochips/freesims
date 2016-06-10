﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace FreeSims
{
    public class Control
    {
        public Control(bool isControllerMode)
        {
            this.isControllerMode = isControllerMode;
        }

        public bool isControllerMode = false;

        public bool DPadRight
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).DPad.Right == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else return false;
            }
        }
        public bool DPadUp
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).DPad.Up == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else return false;
            }
        }
        public bool DPadLeft
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else return false;
            }
        }
        public bool DPadDown
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).DPad.Down == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else return false;
            }
        }

        public float LeftStickX
        {
            get
            {
                return GamePad.GetState(PlayerIndex.One).ThumbSticks.Left.X;
            }
        }
        public float LeftStickY
        {
            get
            {
                return GamePad.GetState(PlayerIndex.One).ThumbSticks.Left.Y;
            }
        }
        public float RightStickX
        {
            get
            {
                return GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.X;
            }
        }
        public float RightStickY
        {
            get
            {
                return GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.Y;
            }
        }

        public bool LeftStick
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.LeftStick == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else
                    return false;
            }
        }
        public bool RightStick
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.RightStick == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else
                    return false;
            }
        }

        public bool A
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.A == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else return false;
            }
        }
        public bool B
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.B == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else return false;
            }
        }
        public bool X
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.X == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else return false;
            }
        }
        public bool Y
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Y == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else
                    return false;
            }
        }

        public bool Home
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.BigButton == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else
                    return false;
            }
        }
        public bool Start
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Start == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else
                    return false;
            }
        }
        public bool Back
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else
                    return false;
            }
        }

        public bool LB
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.LeftShoulder == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else
                    return false;
            }
        }
        public bool RB
        {
            get
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.RightShoulder == ButtonState.Pressed)
                {
                    isControllerMode = true;
                    return true;
                }
                else
                    return false;
            }
        }
        public float L
        {
            get
            {
                return GamePad.GetState(PlayerIndex.One).Triggers.Left;
            }
        }
        public float R
        {
            get
            {
                return GamePad.GetState(PlayerIndex.One).Triggers.Right;
            }
        }

        public bool LeftMouseClick
        {
            get
            {
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    isControllerMode = false;
                    return true;
                }
                else return false;
            }
        }
        public bool RightMouseClick
        {
            get
            {
                if (Mouse.GetState().RightButton == ButtonState.Pressed)
                {
                    isControllerMode = false;
                    return true;
                }
                else return false;
            }
        }
        public bool MiddleMouseClick
        {
            get
            {
                if (Mouse.GetState().MiddleButton == ButtonState.Pressed)
                {
                    isControllerMode = false;
                    return true;
                }
                else return false;
            }
        }
    }
}
