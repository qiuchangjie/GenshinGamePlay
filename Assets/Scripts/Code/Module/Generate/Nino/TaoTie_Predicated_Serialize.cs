/* this is generated by nino */
namespace TaoTie
{
    public partial class Predicated
    {
        public static Predicated.SerializationHelper NinoSerializationHelper = new Predicated.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<Predicated>
        {
            #region NINO_CODEGEN
            public override void Serialize(Predicated value, Nino.Serialization.Writer writer)
            {
                if(value == null)
                {
                    writer.Write(false);
                    return;
                }
                writer.Write(true);
                writer.CompressAndWriteEnum<TaoTie.AbilityTargetting>(value.Targetting);
                writer.WriteCommonVal<TaoTie.ConfigSelectTargets>(value.OtherTargets);
                writer.WriteCommonVal<TaoTie.ConfigAbilityPredicate>(value.Predicate);
                writer.WriteCommonVal<TaoTie.ConfigAbilityPredicate>(value.PredicateForeach);
                writer.WriteCommonVal<TaoTie.ConfigAbilityPredicate>(value.TargetPredicate);
                writer.Write(value.SuccessActions);
                writer.Write(value.FailActions);
            }

            public override Predicated Deserialize(Nino.Serialization.Reader reader)
            {
                if(!reader.ReadBool())
                    return null;
                Predicated value = new Predicated();
                reader.DecompressAndReadEnum<TaoTie.AbilityTargetting>(ref value.Targetting);
                value.OtherTargets = reader.ReadCommonVal<TaoTie.ConfigSelectTargets>();
                value.Predicate = reader.ReadCommonVal<TaoTie.ConfigAbilityPredicate>();
                value.PredicateForeach = reader.ReadCommonVal<TaoTie.ConfigAbilityPredicate>();
                value.TargetPredicate = reader.ReadCommonVal<TaoTie.ConfigAbilityPredicate>();
                value.SuccessActions = reader.ReadArray<TaoTie.ConfigAbilityAction>();
                value.FailActions = reader.ReadArray<TaoTie.ConfigAbilityAction>();
                return value;
            }
            #endregion
        }
    }
}