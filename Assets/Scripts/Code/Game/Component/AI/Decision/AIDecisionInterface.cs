﻿namespace TaoTie
{
	public class AIDecisionInterface
	{
		public static bool IsOnAwareValid(AIKnowledge knowledge) => default;
		public static bool IsOnAlertValid(AIKnowledge knowledge) => default;
		public static bool IsOnNerveValid(AIKnowledge knowledge) => default;
		public static bool IsReturnToBornPosValid(AIKnowledge knowledge)
		{
			// if (!knowledge.returnToBornKnowledge.config.enable)
			// 	return false;
			// if (!knowledge.isReturnToBorn)
			// 	return false;
			return true;
		}

		public static bool IsInvestigateValid(AIKnowledge knowledge) => default;
		public static bool IsReactActionPointValid(AIKnowledge knowledge) => default;
		public static bool IsPatrolFollowValid(AIKnowledge knowledge) => default;
		public static bool IsFollowServerRouteValid(AIKnowledge knowledge) => default;
		public static bool IsCombatFollowMoveValid(AIKnowledge knowledge) => default;
		public static bool IsFreeSkillValid(AIKnowledge knowledge) => default;
		public static bool IsFollowScriptedPathValid(AIKnowledge knowledge) => default;
		public static bool IsSpacialProbeValid(AIKnowledge knowledge) => default;
		public static bool IsWanderValid(AIKnowledge knowledge)
		{
			// if (!knowledge.wanderTacticKnowledge.config.enable)
			// 	return false;
			// if (knowledge.moveControlState.wanderInfo.nextAvailableTick > Time.time)
			// 	return false;
			return true;
		}

		public static bool IsIdleValid(AIKnowledge knowledge) => default;
		public static bool IsCombatValid(AIKnowledge knowledge) => default;
		public static bool IsCombatBuddySkillValid(AIKnowledge knowledge) => default;
		public static bool IsCombatSkillExecuteValid(AIKnowledge knowledge) => default;
		public static bool IsCombatSkillPrepareValid(AIKnowledge knowledge) => default;
		public static bool IsCombatFixedMoveValid(AIKnowledge knowledge) => default;
		public static bool IsCombatMeleeChargeValid(AIKnowledge knowledge)
		{
			knowledge.meleeChargeTactic.SwitchSetting(knowledge.poseID);
			float meleeChargeStartDistanceMin = knowledge.meleeChargeTactic.data.startDistanceMin;
			float meleeChargeStartDistanceMax = knowledge.meleeChargeTactic.data.startDistanceMax;
			
			if (!knowledge.meleeChargeTactic.config.Enable)
				return false;
			if (!knowledge.meleeChargeTactic.NerveCheck(knowledge))
				return false;
			if (knowledge.targetKnowledge.targetDistance > meleeChargeStartDistanceMax)
				return false;
			if (knowledge.targetKnowledge.targetDistance < meleeChargeStartDistanceMin)
				return false;
			return true;
		}
		public static bool IsCombatFacingMoveValid(AIKnowledge knowledge)
		{
			if (!knowledge.facingMoveTactic.config.Enable)
				return false;
			if (!knowledge.facingMoveTactic.NerveCheck(knowledge))
				return false;
			return true;
		}
		public static bool IsCombatSurroundValid(AIKnowledge knowledge) => default;
		public static bool IsCombatFindBackValid(AIKnowledge knowledge) => default;
		public static bool IsCombatCrabMoveValid(AIKnowledge knowledge) => default;
		public static bool IsCombatSpacialChaseValid(AIKnowledge knowledge) => default;
		public static bool IsCombatSpacialAdjustValid(AIKnowledge knowledge) => default;
		public static bool IsCombatIdleValid(AIKnowledge knowledge) => default;
		public static bool IsScriptedMoveToValid(AIKnowledge knowledge) => default;
		public static bool IsLandingValid(AIKnowledge knowledge) => default;
		public static bool IsExtractionValid(AIKnowledge knowledge) => default;
		public static bool IsFleeValid(AIKnowledge knowledge)
		{
			knowledge.fleeTactic.SwitchSetting(knowledge.poseID);
			float triggerDistance = knowledge.fleeTactic.data.triggerDistance;
			if (!knowledge.fleeTactic.config.Enable)
				return false;
			if (!knowledge.fleeTactic.NerveCheck(knowledge))
				return false;
			if (knowledge.moveControlState.FleeInfo.nextAvailableTick > GameTimerManager.Instance.GetTimeNow())
				return false;
			if (knowledge.targetKnowledge.targetDistance > triggerDistance)
				return false;
			return true;
		}
		public static bool IsBirdCirclingValid(AIKnowledge knowledge) => default;
		public static bool IsBrownianMotionValid(AIKnowledge knowledge) => default;
		public static bool IsAutoPlayerFollowTargetValid(AIKnowledge knowledge) => default;
		public static bool IsAutoPlayerCombatSkillExecuteValid(AIKnowledge knowledge) => default;
		public static bool IsAutoPlayerCombatSkillPrepareValid(AIKnowledge knowledge) => default;
	}
}