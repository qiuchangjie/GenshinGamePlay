﻿namespace TaoTie
{
    public class Equip : Unit,IEntity<int>
    {

        #region IEntity

        public override EntityType Type => EntityType.Equip;

        public void Init(int configId)
        {
            var weapon = AddComponent<EquipComponent,int>(configId);
            ConfigId = weapon.Config.UnitId;
            if (!string.IsNullOrEmpty(Config.EntityConfig))
            {
                ConfigEntity = ResourcesManager.Instance.LoadConfig<ConfigEntity>(Config.EntityConfig);
            }
            AddComponent<AttachComponent>();
            AddComponent<GameObjectHolderComponent>();
            AddComponent<FsmComponent,ConfigFsmController>(ResourcesManager.Instance.LoadConfig<ConfigFsmController>(Config.FSM));
        }

        public void Destroy()
        {
            ConfigId = default;
        }

        #endregion
    }
}