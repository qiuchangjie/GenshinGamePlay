﻿using System;
using Nino.Serialization;
using Sirenix.OdinInspector;
using UnityEngine;

namespace TaoTie
{
    [NinoSerialize]
    public sealed partial class ConfigGearActorMonster : ConfigGearActor
    {
        [NinoMember(10)]
        public int configID;

        public override Entity CreateActor(Gear gear)
        {
            var entity = gear.Parent.CreateEntity<Monster, int,Vector3>(configID,position);
            entity.CampId = campId;
            entity.AddComponent<GearActorComponent, int, long>(localId, gear.Id);
            return entity;
        }
    }
}