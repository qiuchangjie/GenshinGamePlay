﻿namespace TaoTie
{
    public class ConfigAfterAddMixin:ConfigAbilityMixin
    {
        public ConfigAbilityAction[] Actions;

        public override AbilityMixin CreateAbilityMixin(ActorAbility actorAbility)
        {
            var res = ObjectPool.Instance.Fetch(typeof(AfterAddMixin)) as AfterAddMixin;
            res.Init(actorAbility,this);
            return res;
        }
    }
}