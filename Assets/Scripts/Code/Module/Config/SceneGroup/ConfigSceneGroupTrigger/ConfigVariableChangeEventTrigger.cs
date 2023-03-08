﻿using System;
using Nino.Serialization;
using Sirenix.OdinInspector;
using UnityEngine;

namespace TaoTie
{
    [LabelText("当关卡的变量改变之后")]
    [NinoSerialize]
    public partial class ConfigVariableChangeEventTrigger : ConfigSceneGroupTrigger<VariableChangeEvent>
    {
        [NinoMember(5)][LabelText("变量")]
        public string key;

        protected override bool CheckCondition(SceneGroup sceneGroup, VariableChangeEvent evt)
        {
            return key == evt.Key;
        } 
    }
}