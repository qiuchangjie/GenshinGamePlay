﻿using Nino.Serialization;
using Sirenix.OdinInspector;

namespace TaoTie
{
    /// <summary>
    /// 受到攻击前
    /// </summary>
    [NinoSerialize][LabelText("受到攻击前DoAction")]
    public partial class ConfigDoActionBeforeBeAttackMixin: ConfigAbilityMixin
    {
        [NinoMember(1)]
        public ConfigAbilityAction[] Actions;
        public override AbilityMixin CreateAbilityMixin(ActorAbility actorAbility, ActorModifier actorModifier)
        {
            var res = ObjectPool.Instance.Fetch(TypeInfo<DoActionBeforeBeAttackMixin>.Type) as DoActionBeforeBeAttackMixin;
            res.Init(actorAbility, actorModifier, this);
            return res;
        }
    }
}