﻿using UnityEngine;

namespace TaoTie
{
    public sealed class CameraHardLockToTargetPluginRunner: CameraBodyPluginRunner<ConfigCameraHardLockToTargetPlugin>
    {
        protected override void InitInternal()
        {
            Calculating();
        }

        protected override void UpdateInternal()
        {
            Calculating();
        }

        protected override void DisposeInternal()
        {
            
        }

        private void Calculating()
        {
            if (state.target != null)
            {
                var dir = state.target.position - data.Position;
                if (dir == Vector3.zero)
                {
                    if (state.follow != null)
                    {
                        data.Orientation = state.follow.rotation;
                    }
                }
                else
                {
                    
                    data.Orientation = Quaternion.FromToRotation(Vector3.forward, dir);
                }
                
            }
        }
    }
}